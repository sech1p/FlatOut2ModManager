namespace FlatOut2_Mod_Manager
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            statusStrip1 = new StatusStrip();
            copyrightInfo = new ToolStripStatusLabel();
            listBoxModsAll = new ListBox();
            listBoxModsEnabled = new ListBox();
            modPanel = new Panel();
            deselectAllButton = new FontAwesome.Sharp.IconButton();
            selectAllButton = new FontAwesome.Sharp.IconButton();
            moveDownButton = new FontAwesome.Sharp.IconButton();
            moveUpButton = new FontAwesome.Sharp.IconButton();
            startGameButton = new FontAwesome.Sharp.IconButton();
            applyButton = new FontAwesome.Sharp.IconButton();
            enabledModsTotalLabel = new Label();
            availableModsTotalLabel = new Label();
            enabledModFilesLabel = new Label();
            availableModFilesLabel = new Label();
            moveFromModsButton = new FontAwesome.Sharp.IconButton();
            moveToModsButton = new FontAwesome.Sharp.IconButton();
            gameInfoPanel = new Panel();
            flatOutVersionLabel = new Label();
            flatOutDirectoryLabel = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addModFromDirectoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            showFilesToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            removeAllModsButton = new FontAwesome.Sharp.IconButton();
            statusStrip1.SuspendLayout();
            modPanel.SuspendLayout();
            gameInfoPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { copyrightInfo });
            statusStrip1.Location = new Point(0, 557);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(659, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // copyrightInfo
            // 
            copyrightInfo.Name = "copyrightInfo";
            copyrightInfo.Size = new Size(88, 17);
            copyrightInfo.Text = "(c) 2024 sech1p";
            // 
            // listBoxModsAll
            // 
            listBoxModsAll.FormattingEnabled = true;
            listBoxModsAll.HorizontalScrollbar = true;
            listBoxModsAll.ItemHeight = 15;
            listBoxModsAll.Location = new Point(4, 31);
            listBoxModsAll.Name = "listBoxModsAll";
            listBoxModsAll.Size = new Size(195, 379);
            listBoxModsAll.TabIndex = 1;
            listBoxModsAll.SelectedIndexChanged += listBoxModsAll_SelectedIndexChanged;
            // 
            // listBoxModsEnabled
            // 
            listBoxModsEnabled.FormattingEnabled = true;
            listBoxModsEnabled.HorizontalScrollbar = true;
            listBoxModsEnabled.ItemHeight = 15;
            listBoxModsEnabled.Location = new Point(288, 31);
            listBoxModsEnabled.Name = "listBoxModsEnabled";
            listBoxModsEnabled.Size = new Size(195, 379);
            listBoxModsEnabled.TabIndex = 2;
            listBoxModsEnabled.SelectedIndexChanged += listBoxModsEnabled_SelectedIndexChanged;
            // 
            // modPanel
            // 
            modPanel.BorderStyle = BorderStyle.FixedSingle;
            modPanel.Controls.Add(removeAllModsButton);
            modPanel.Controls.Add(deselectAllButton);
            modPanel.Controls.Add(selectAllButton);
            modPanel.Controls.Add(moveDownButton);
            modPanel.Controls.Add(moveUpButton);
            modPanel.Controls.Add(startGameButton);
            modPanel.Controls.Add(applyButton);
            modPanel.Controls.Add(enabledModsTotalLabel);
            modPanel.Controls.Add(availableModsTotalLabel);
            modPanel.Controls.Add(enabledModFilesLabel);
            modPanel.Controls.Add(availableModFilesLabel);
            modPanel.Controls.Add(moveFromModsButton);
            modPanel.Controls.Add(moveToModsButton);
            modPanel.Controls.Add(listBoxModsEnabled);
            modPanel.Controls.Add(listBoxModsAll);
            modPanel.Location = new Point(0, 83);
            modPanel.Name = "modPanel";
            modPanel.Size = new Size(659, 471);
            modPanel.TabIndex = 3;
            // 
            // deselectAllButton
            // 
            deselectAllButton.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            deselectAllButton.IconColor = Color.Black;
            deselectAllButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deselectAllButton.IconSize = 24;
            deselectAllButton.Location = new Point(489, 188);
            deselectAllButton.Name = "deselectAllButton";
            deselectAllButton.Size = new Size(165, 34);
            deselectAllButton.TabIndex = 14;
            deselectAllButton.Text = "                            Deselect all";
            deselectAllButton.UseVisualStyleBackColor = true;
            deselectAllButton.Click += deselectAllButton_Click;
            // 
            // selectAllButton
            // 
            selectAllButton.IconChar = FontAwesome.Sharp.IconChar.Check;
            selectAllButton.IconColor = Color.Black;
            selectAllButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            selectAllButton.IconSize = 24;
            selectAllButton.Location = new Point(489, 148);
            selectAllButton.Name = "selectAllButton";
            selectAllButton.Size = new Size(165, 34);
            selectAllButton.TabIndex = 13;
            selectAllButton.Text = "                            Select all";
            selectAllButton.UseVisualStyleBackColor = true;
            selectAllButton.Click += selectAllButton_Click;
            // 
            // moveDownButton
            // 
            moveDownButton.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            moveDownButton.IconColor = Color.Black;
            moveDownButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            moveDownButton.IconSize = 24;
            moveDownButton.Location = new Point(489, 71);
            moveDownButton.Name = "moveDownButton";
            moveDownButton.Size = new Size(165, 34);
            moveDownButton.TabIndex = 12;
            moveDownButton.Text = "                            Move down";
            moveDownButton.UseVisualStyleBackColor = true;
            moveDownButton.Click += moveDownButton_Click;
            // 
            // moveUpButton
            // 
            moveUpButton.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            moveUpButton.IconColor = Color.Black;
            moveUpButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            moveUpButton.IconSize = 24;
            moveUpButton.Location = new Point(489, 31);
            moveUpButton.Name = "moveUpButton";
            moveUpButton.Size = new Size(165, 34);
            moveUpButton.TabIndex = 11;
            moveUpButton.Text = "                        Move up";
            moveUpButton.UseVisualStyleBackColor = true;
            moveUpButton.Click += moveUpButton_Click;
            // 
            // startGameButton
            // 
            startGameButton.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            startGameButton.IconColor = Color.Black;
            startGameButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            startGameButton.IconSize = 24;
            startGameButton.Location = new Point(296, 433);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(187, 35);
            startGameButton.TabIndex = 10;
            startGameButton.Text = "                                Start Game";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // applyButton
            // 
            applyButton.IconChar = FontAwesome.Sharp.IconChar.Gear;
            applyButton.IconColor = Color.Black;
            applyButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            applyButton.IconSize = 24;
            applyButton.Location = new Point(12, 433);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(187, 35);
            applyButton.TabIndex = 9;
            applyButton.Text = "                    Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // enabledModsTotalLabel
            // 
            enabledModsTotalLabel.AutoSize = true;
            enabledModsTotalLabel.Location = new Point(288, 415);
            enabledModsTotalLabel.Name = "enabledModsTotalLabel";
            enabledModsTotalLabel.Size = new Size(43, 15);
            enabledModsTotalLabel.TabIndex = 8;
            enabledModsTotalLabel.Text = "Total: -";
            // 
            // availableModsTotalLabel
            // 
            availableModsTotalLabel.AutoSize = true;
            availableModsTotalLabel.Location = new Point(3, 415);
            availableModsTotalLabel.Name = "availableModsTotalLabel";
            availableModsTotalLabel.Size = new Size(43, 15);
            availableModsTotalLabel.TabIndex = 7;
            availableModsTotalLabel.Text = "Total: -";
            // 
            // enabledModFilesLabel
            // 
            enabledModFilesLabel.AutoSize = true;
            enabledModFilesLabel.Location = new Point(288, 13);
            enabledModFilesLabel.Name = "enabledModFilesLabel";
            enabledModFilesLabel.Size = new Size(101, 15);
            enabledModFilesLabel.TabIndex = 6;
            enabledModFilesLabel.Text = "Enabled Mod files";
            // 
            // availableModFilesLabel
            // 
            availableModFilesLabel.AutoSize = true;
            availableModFilesLabel.Location = new Point(4, 13);
            availableModFilesLabel.Name = "availableModFilesLabel";
            availableModFilesLabel.Size = new Size(107, 15);
            availableModFilesLabel.TabIndex = 5;
            availableModFilesLabel.Text = "Available Mod files";
            // 
            // moveFromModsButton
            // 
            moveFromModsButton.Enabled = false;
            moveFromModsButton.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            moveFromModsButton.IconColor = Color.Black;
            moveFromModsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            moveFromModsButton.Location = new Point(205, 31);
            moveFromModsButton.Name = "moveFromModsButton";
            moveFromModsButton.RightToLeft = RightToLeft.No;
            moveFromModsButton.Size = new Size(77, 188);
            moveFromModsButton.TabIndex = 4;
            moveFromModsButton.UseVisualStyleBackColor = true;
            moveFromModsButton.Click += moveFromModsButton_Click;
            // 
            // moveToModsButton
            // 
            moveToModsButton.Enabled = false;
            moveToModsButton.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            moveToModsButton.IconColor = Color.Black;
            moveToModsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            moveToModsButton.Location = new Point(205, 225);
            moveToModsButton.Name = "moveToModsButton";
            moveToModsButton.RightToLeft = RightToLeft.No;
            moveToModsButton.Size = new Size(77, 185);
            moveToModsButton.TabIndex = 3;
            moveToModsButton.UseVisualStyleBackColor = true;
            moveToModsButton.Click += moveToModsButton_Click;
            // 
            // gameInfoPanel
            // 
            gameInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            gameInfoPanel.Controls.Add(flatOutVersionLabel);
            gameInfoPanel.Controls.Add(flatOutDirectoryLabel);
            gameInfoPanel.Controls.Add(label1);
            gameInfoPanel.Location = new Point(0, 25);
            gameInfoPanel.Name = "gameInfoPanel";
            gameInfoPanel.Size = new Size(659, 52);
            gameInfoPanel.TabIndex = 4;
            // 
            // flatOutVersionLabel
            // 
            flatOutVersionLabel.AutoSize = true;
            flatOutVersionLabel.Location = new Point(4, 30);
            flatOutVersionLabel.Name = "flatOutVersionLabel";
            flatOutVersionLabel.Size = new Size(107, 15);
            flatOutVersionLabel.TabIndex = 2;
            flatOutVersionLabel.Text = "FlatOut 2 Version: -";
            // 
            // flatOutDirectoryLabel
            // 
            flatOutDirectoryLabel.AutoSize = true;
            flatOutDirectoryLabel.Location = new Point(4, 15);
            flatOutDirectoryLabel.Name = "flatOutDirectoryLabel";
            flatOutDirectoryLabel.Size = new Size(117, 15);
            flatOutDirectoryLabel.TabIndex = 1;
            flatOutDirectoryLabel.Text = "FlatOut 2 Directory: -";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Game Info";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, showFilesToolStripMenuItem, updateToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(659, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addModFromDirectoryToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // addModFromDirectoryToolStripMenuItem
            // 
            addModFromDirectoryToolStripMenuItem.Name = "addModFromDirectoryToolStripMenuItem";
            addModFromDirectoryToolStripMenuItem.Size = new Size(203, 22);
            addModFromDirectoryToolStripMenuItem.Text = "Add mod from directory";
            addModFromDirectoryToolStripMenuItem.Click += addModFromDirectoryToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(203, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // showFilesToolStripMenuItem
            // 
            showFilesToolStripMenuItem.Name = "showFilesToolStripMenuItem";
            showFilesToolStripMenuItem.Size = new Size(74, 20);
            showFilesToolStripMenuItem.Text = "Show Files";
            showFilesToolStripMenuItem.Click += showFilesToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(57, 20);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // removeAllModsButton
            // 
            removeAllModsButton.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            removeAllModsButton.IconColor = Color.Black;
            removeAllModsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            removeAllModsButton.IconSize = 24;
            removeAllModsButton.Location = new Point(489, 270);
            removeAllModsButton.Name = "removeAllModsButton";
            removeAllModsButton.Size = new Size(165, 34);
            removeAllModsButton.TabIndex = 15;
            removeAllModsButton.Text = "                            Remove all";
            removeAllModsButton.UseVisualStyleBackColor = true;
            removeAllModsButton.Click += removeAllModsButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 579);
            Controls.Add(gameInfoPanel);
            Controls.Add(modPanel);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "mainForm";
            Text = "FlatOut 2 Mod Manager";
            Load += mainForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            modPanel.ResumeLayout(false);
            modPanel.PerformLayout();
            gameInfoPanel.ResumeLayout(false);
            gameInfoPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel copyrightInfo;
        private ListBox listBoxModsAll;
        private ListBox listBoxModsEnabled;
        private Panel modPanel;
        private FontAwesome.Sharp.IconButton moveToModsButton;
        private FontAwesome.Sharp.IconButton moveFromModsButton;
        private Label enabledModFilesLabel;
        private Label availableModFilesLabel;
        private Label enabledModsTotalLabel;
        private Label availableModsTotalLabel;
        private FontAwesome.Sharp.IconButton applyButton;
        private FontAwesome.Sharp.IconButton startGameButton;
        private Panel gameInfoPanel;
        private Label label1;
        private Label flatOutVersionLabel;
        private Label flatOutDirectoryLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addModFromDirectoryToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem showFilesToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private FontAwesome.Sharp.IconButton moveDownButton;
        private FontAwesome.Sharp.IconButton moveUpButton;
        private FontAwesome.Sharp.IconButton deselectAllButton;
        private FontAwesome.Sharp.IconButton selectAllButton;
        private FontAwesome.Sharp.IconButton removeAllModsButton;
    }
}
