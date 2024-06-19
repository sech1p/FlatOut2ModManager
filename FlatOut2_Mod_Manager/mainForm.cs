using System.Diagnostics;
using System.Net;
using System.Text;
using Microsoft.Win32;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace FlatOut2_Mod_Manager
{
    public partial class mainForm : Form
    {
        private string FlatOutDirectory;
        private string[] patch;
        private List<string> allMods;
        private List<string> allEnabledMods;
        private bool isSteam;

        public mainForm()
        {
            InitializeComponent();
            allMods = new List<string>();
            allEnabledMods = new List<string>();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var key = Registry.CurrentUser.OpenSubKey("Software", true);

            key.CreateSubKey("FlatOut2_Mod_Manager");
            key = key.OpenSubKey("FlatOut2_Mod_Manager", true);

            var flatOutDirectoryValue = key.GetValue("FlatOutDirectory");
            if (flatOutDirectoryValue != null)
            {
                FlatOutDirectory = flatOutDirectoryValue.ToString();
            }
            else
            {
                goto selectFolder;
            }

        selectFolder:
            if (String.IsNullOrEmpty(FlatOutDirectory))
            {
                using (var folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Select folder with your FlatOut 2 installation";
                    DialogResult result = folderBrowserDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        if (!folderBrowserDialog.SelectedPath.Contains("FlatOut"))
                        {
                            MessageBox.Show("Invalid FlatOut 2 directory", Application.ProductName,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto selectFolder;
                        }
                        else
                        {
                            FlatOutDirectory = folderBrowserDialog.SelectedPath;
                        }
                    }
                    else
                    {
                        goto selectFolder;
                    }
                }
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(FlatOutDirectory);
            FileInfo[] files = directoryInfo.GetFiles();

            if (!File.Exists($"{FlatOutDirectory}\\FlatOut2.exe"))
            {
                MessageBox.Show("Invalid FlatOut 2 directory", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto selectFolder;
            }

            key.SetValue("FlatOutDirectory", FlatOutDirectory);

            if (FlatOutDirectory.Contains("Steam"))
            {
                isSteam = true;
            }
            else
            {
                isSteam = false;
            }

            foreach (var file in files)
            {
                if (file.Name.EndsWith("bfs") && file.Name != "fo2a.bfs" &&
                    file.Name != "fo2b.bfs" &&
                    file.Name != "fo2c.bfs")
                {
                    allMods.Add(file.Name);
                    listBoxModsAll.Items.Add(file.Name);
                }
            }

            patch = File.ReadAllLines($"{FlatOutDirectory}\\patch");
            foreach (var file in patch)
            {
                allEnabledMods.Add(file);
                listBoxModsEnabled.Items.Add(file);
            }

            flatOutDirectoryLabel.Text = $"FlatOut 2 Directory: {FlatOutDirectory}";
            if (isSteam)
            {
                flatOutVersionLabel.Text = "FlatOut 2 Version: 1.2 (Steam)";
                if (File.Exists($"{FlatOutDirectory}\\txt.bfs")) // Polish translation
                {
                    flatOutVersionLabel.Text = "FlatOut 2 Version: 1.0 (Steam)";
                }
            }
            else
            {
                flatOutVersionLabel.Text = "FlatOut 2 Version: 1.0";
            }

            availableModsTotalLabel.Text = $"Total: {allMods.Count}";
            enabledModsTotalLabel.Text = $"Total: {allEnabledMods.Count}";
        }

        private void listBoxModsAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveToModsButton.Enabled = true;
        }

        private void moveToModsButton_Click(object sender, EventArgs e)
        {
            if (listBoxModsAll.SelectedIndex != -1)
            {
                var mod = listBoxModsAll.Items[listBoxModsAll.SelectedIndex];
                if (!allEnabledMods.Contains(mod))
                {
                    allEnabledMods.Add(mod.ToString());
                    listBoxModsEnabled.Items.Add(mod);
                    enabledModsTotalLabel.Text = $"Total: {allEnabledMods.Count}";
                }
            }
            else
            {
                moveToModsButton.Enabled = false;
            }
        }

        private void moveFromModsButton_Click(object sender, EventArgs e)
        {
            if (listBoxModsEnabled.SelectedIndex != -1)
            {
                var mod = listBoxModsEnabled.Items[listBoxModsEnabled.SelectedIndex];
                listBoxModsEnabled.Items.Remove(mod);
                allEnabledMods.Remove(mod.ToString());
                enabledModsTotalLabel.Text = $"Total: {allEnabledMods.Count}";
            }
            else
            {
                moveFromModsButton.Enabled = false;
            }
        }

        private void listBoxModsEnabled_SelectedIndexChanged(object sender, EventArgs e)
        {
            moveFromModsButton.Enabled = true;
            moveUpButton.Enabled = true;
            moveDownButton.Enabled = true;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            File.Create($"{FlatOutDirectory}\\patch").Close();

            var stringBuilder = new StringBuilder();
            foreach (var mod in allEnabledMods)
            {
                stringBuilder.AppendLine(mod);
            }

            File.WriteAllText($"{FlatOutDirectory}\\patch", RemoveLast(stringBuilder.ToString(), "\r\n"));

            MessageBox.Show("Applied successfully", Application.ProductName, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (isSteam)
            {
                var steamProcess = Process.GetProcessesByName("Steam");
                var steamFileName = steamProcess[0].MainModule.FileName;
                if (File.Exists(steamFileName))
                {
                    var steamFlatoutProcess = new ProcessStartInfo();
                    steamFlatoutProcess.FileName = steamFileName;
                    steamFlatoutProcess.Arguments = "-applaunch 2990";

                    Process.Start(steamFlatoutProcess);
                }
            }
            else
            {
                Process.Start($"{FlatOutDirectory}\\FlatOut2.exe");
            }
        }

        private string RemoveLast(string source, string value)
        {
            int index = source.LastIndexOf(value);
            return index != -1 ? source.Remove(index, value.Length) : source;
        }

        private void showFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var flatOutDirectory = new ProcessStartInfo();
            flatOutDirectory.FileName = "explorer.exe";
            flatOutDirectory.Arguments = FlatOutDirectory;

            Process.Start(flatOutDirectory);
        }

        private void addModFromDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "BFS files (.bfs)|*.bfs";
                openFileDialog.RestoreDirectory = true;
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var file = openFileDialog.FileName;
                    var saferFileName = openFileDialog.SafeFileName;
                    File.Copy(file, $"{FlatOutDirectory}\\{saferFileName}");

                    allMods.Add(saferFileName);
                    listBoxModsAll.Items.Add(saferFileName);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var versionRequest = httpClient.GetAsync("https://sech1p.ovh/projects/fo2_modmanager/version").Result.Content;
            var version = versionRequest.ReadAsStringAsync().Result;

            if (Application.ProductVersion != version)
            {
                var updateDialogResult = MessageBox.Show("New version is available\r\nDo you want to download it?", Application.ProductName,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (updateDialogResult == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://github.com/sech1p/FlatOut2ModManager/releases",
                        UseShellExecute = true,
                    });
                }
            }
            else
            {
                MessageBox.Show("Your version is up to date", Application.ProductName, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new aboutForm();
            aboutForm.Show();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            if (listBoxModsEnabled.SelectedIndex != -1)
            {
                var selectedMod = listBoxModsEnabled.Items[listBoxModsEnabled.SelectedIndex];
                var newIndex = listBoxModsEnabled.SelectedIndex - 1;

                listBoxModsEnabled.Items.Remove(selectedMod);
                listBoxModsEnabled.Items.Insert(newIndex, selectedMod);
                listBoxModsEnabled.SetSelected(newIndex, true);

            }
            else
            {
                moveUpButton.Enabled = true;
            }
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            if (listBoxModsEnabled.SelectedIndex != -1)
            {
                var selectedMod = listBoxModsEnabled.Items[listBoxModsEnabled.SelectedIndex];
                var newIndex = listBoxModsEnabled.SelectedIndex + 1;

                try
                {
                    listBoxModsEnabled.Items.Remove(selectedMod);
                    listBoxModsEnabled.Items.Insert(newIndex, selectedMod);
                    listBoxModsEnabled.SetSelected(newIndex, true);
                }
                catch (ArgumentOutOfRangeException exception)
                {
                    listBoxModsEnabled.Items.Add(selectedMod);
                    listBoxModsEnabled.SetSelected(newIndex - 1, true);
                    return;
                }
            }
            else
            {
                moveDownButton.Enabled = true;
            }
        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            listBoxModsEnabled.SelectionMode = SelectionMode.MultiSimple;
            for (int i = 0; i < listBoxModsEnabled.Items.Count; i++)
                listBoxModsEnabled.SetSelected(i, true);
        }

        private void deselectAllButton_Click(object sender, EventArgs e)
        {
            listBoxModsEnabled.SelectionMode = SelectionMode.MultiSimple;
            for (int i = 0; i < listBoxModsEnabled.Items.Count; i++)
                listBoxModsEnabled.SetSelected(i, false);
        }

        private void removeAllModsButton_Click(object sender, EventArgs e)
        { 
            listBoxModsEnabled.Items.Clear();
            allEnabledMods.RemoveAll(RemoveAll);
            enabledModsTotalLabel.Text = $"Total: {allEnabledMods.Count}";
        }

        private static bool RemoveAll(String str)
        {
            return str.ToLower().EndsWith(".bfs");
        }
    }
}
