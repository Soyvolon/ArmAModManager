namespace ArmAModManager;

partial class ClientMain
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.primaryStatus = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.exportProfile = new System.Windows.Forms.Button();
            this.importProfile = new System.Windows.Forms.Button();
            this.modSyncBox = new System.Windows.Forms.GroupBox();
            this.syncAllMods = new System.Windows.Forms.Button();
            this.testConnection = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.syncPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.syncUsername = new System.Windows.Forms.TextBox();
            this.syncPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.syncServer = new System.Windows.Forms.TextBox();
            this.syncOnLaunch = new System.Windows.Forms.CheckBox();
            this.updateModFolder = new System.Windows.Forms.Button();
            this.modFolderPathDisplay = new System.Windows.Forms.TextBox();
            this.createProfile = new System.Windows.Forms.Button();
            this.profileSelector = new System.Windows.Forms.ComboBox();
            this.loadProfile = new System.Windows.Forms.Button();
            this.armaFolderUpdate = new System.Windows.Forms.Button();
            this.armaFolderDisplay = new System.Windows.Forms.TextBox();
            this.modTabs = new System.Windows.Forms.TabControl();
            this.requiredMods = new System.Windows.Forms.TabPage();
            this.modlistBox = new System.Windows.Forms.ListBox();
            this.updateMods = new System.Windows.Forms.Button();
            this.whitelistMods = new System.Windows.Forms.TabPage();
            this.whitelistBox = new System.Windows.Forms.CheckedListBox();
            this.updateWhitelist = new System.Windows.Forms.Button();
            this.primaryMenu = new System.Windows.Forms.MenuStrip();
            this.folderSelectDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.modSyncBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syncPort)).BeginInit();
            this.modTabs.SuspendLayout();
            this.requiredMods.SuspendLayout();
            this.whitelistMods.SuspendLayout();
            this.SuspendLayout();
            // 
            // primaryStatus
            // 
            this.primaryStatus.Location = new System.Drawing.Point(0, 515);
            this.primaryStatus.Name = "primaryStatus";
            this.primaryStatus.Size = new System.Drawing.Size(1116, 22);
            this.primaryStatus.TabIndex = 0;
            this.primaryStatus.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.modTabs);
            this.splitContainer1.Size = new System.Drawing.Size(1116, 491);
            this.splitContainer1.SplitterDistance = 754;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.exportProfile);
            this.splitContainer2.Panel1.Controls.Add(this.importProfile);
            this.splitContainer2.Panel1.Controls.Add(this.modSyncBox);
            this.splitContainer2.Panel1.Controls.Add(this.updateModFolder);
            this.splitContainer2.Panel1.Controls.Add(this.modFolderPathDisplay);
            this.splitContainer2.Panel1.Controls.Add(this.createProfile);
            this.splitContainer2.Panel1.Controls.Add(this.profileSelector);
            this.splitContainer2.Panel1.Controls.Add(this.loadProfile);
            this.splitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.armaFolderUpdate);
            this.splitContainer2.Panel2.Controls.Add(this.armaFolderDisplay);
            this.splitContainer2.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer2.Size = new System.Drawing.Size(754, 491);
            this.splitContainer2.SplitterDistance = 311;
            this.splitContainer2.TabIndex = 0;
            // 
            // exportProfile
            // 
            this.exportProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportProfile.Location = new System.Drawing.Point(624, 127);
            this.exportProfile.Name = "exportProfile";
            this.exportProfile.Size = new System.Drawing.Size(127, 23);
            this.exportProfile.TabIndex = 7;
            this.exportProfile.Text = "Export Profile";
            this.exportProfile.UseVisualStyleBackColor = true;
            // 
            // importProfile
            // 
            this.importProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importProfile.Location = new System.Drawing.Point(624, 98);
            this.importProfile.Name = "importProfile";
            this.importProfile.Size = new System.Drawing.Size(127, 23);
            this.importProfile.TabIndex = 6;
            this.importProfile.Text = "Import Profile";
            this.importProfile.UseVisualStyleBackColor = true;
            // 
            // modSyncBox
            // 
            this.modSyncBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modSyncBox.Controls.Add(this.syncAllMods);
            this.modSyncBox.Controls.Add(this.testConnection);
            this.modSyncBox.Controls.Add(this.saveChanges);
            this.modSyncBox.Controls.Add(this.label4);
            this.modSyncBox.Controls.Add(this.syncPassword);
            this.modSyncBox.Controls.Add(this.label3);
            this.modSyncBox.Controls.Add(this.syncUsername);
            this.modSyncBox.Controls.Add(this.syncPort);
            this.modSyncBox.Controls.Add(this.label2);
            this.modSyncBox.Controls.Add(this.label1);
            this.modSyncBox.Controls.Add(this.syncServer);
            this.modSyncBox.Controls.Add(this.syncOnLaunch);
            this.modSyncBox.Location = new System.Drawing.Point(12, 70);
            this.modSyncBox.Name = "modSyncBox";
            this.modSyncBox.Size = new System.Drawing.Size(606, 228);
            this.modSyncBox.TabIndex = 5;
            this.modSyncBox.TabStop = false;
            this.modSyncBox.Text = "Mod Sync";
            // 
            // syncAllMods
            // 
            this.syncAllMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.syncAllMods.Location = new System.Drawing.Point(454, 122);
            this.syncAllMods.Name = "syncAllMods";
            this.syncAllMods.Size = new System.Drawing.Size(146, 23);
            this.syncAllMods.TabIndex = 12;
            this.syncAllMods.Text = "Sync All Mods";
            this.syncAllMods.UseVisualStyleBackColor = true;
            this.syncAllMods.Click += new System.EventHandler(this.SyncAllMods_Click);
            // 
            // testConnection
            // 
            this.testConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testConnection.Location = new System.Drawing.Point(454, 93);
            this.testConnection.Name = "testConnection";
            this.testConnection.Size = new System.Drawing.Size(146, 23);
            this.testConnection.TabIndex = 11;
            this.testConnection.Text = "Test Connection";
            this.testConnection.UseVisualStyleBackColor = true;
            // 
            // saveChanges
            // 
            this.saveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChanges.Location = new System.Drawing.Point(454, 199);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(146, 23);
            this.saveChanges.TabIndex = 10;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // syncPassword
            // 
            this.syncPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.syncPassword.Location = new System.Drawing.Point(72, 94);
            this.syncPassword.Name = "syncPassword";
            this.syncPassword.PasswordChar = '*';
            this.syncPassword.Size = new System.Drawing.Size(376, 23);
            this.syncPassword.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username:";
            // 
            // syncUsername
            // 
            this.syncUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.syncUsername.Location = new System.Drawing.Point(72, 65);
            this.syncUsername.Name = "syncUsername";
            this.syncUsername.Size = new System.Drawing.Size(376, 23);
            this.syncUsername.TabIndex = 6;
            // 
            // syncPort
            // 
            this.syncPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.syncPort.Location = new System.Drawing.Point(374, 37);
            this.syncPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.syncPort.Name = "syncPort";
            this.syncPort.Size = new System.Drawing.Size(74, 23);
            this.syncPort.TabIndex = 5;
            this.syncPort.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server:";
            // 
            // syncServer
            // 
            this.syncServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.syncServer.Location = new System.Drawing.Point(54, 36);
            this.syncServer.Name = "syncServer";
            this.syncServer.Size = new System.Drawing.Size(276, 23);
            this.syncServer.TabIndex = 1;
            // 
            // syncOnLaunch
            // 
            this.syncOnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.syncOnLaunch.AutoSize = true;
            this.syncOnLaunch.Checked = true;
            this.syncOnLaunch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.syncOnLaunch.Location = new System.Drawing.Point(6, 203);
            this.syncOnLaunch.Name = "syncOnLaunch";
            this.syncOnLaunch.Size = new System.Drawing.Size(112, 19);
            this.syncOnLaunch.TabIndex = 0;
            this.syncOnLaunch.Text = "Sync On Launch";
            this.syncOnLaunch.UseVisualStyleBackColor = true;
            // 
            // updateModFolder
            // 
            this.updateModFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateModFolder.Location = new System.Drawing.Point(624, 12);
            this.updateModFolder.Name = "updateModFolder";
            this.updateModFolder.Size = new System.Drawing.Size(127, 23);
            this.updateModFolder.TabIndex = 4;
            this.updateModFolder.Text = "Update Mod Folder";
            this.updateModFolder.UseVisualStyleBackColor = true;
            // 
            // modFolderPathDisplay
            // 
            this.modFolderPathDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modFolderPathDisplay.Location = new System.Drawing.Point(12, 12);
            this.modFolderPathDisplay.Name = "modFolderPathDisplay";
            this.modFolderPathDisplay.ReadOnly = true;
            this.modFolderPathDisplay.Size = new System.Drawing.Size(606, 23);
            this.modFolderPathDisplay.TabIndex = 3;
            // 
            // createProfile
            // 
            this.createProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createProfile.Location = new System.Drawing.Point(624, 69);
            this.createProfile.Name = "createProfile";
            this.createProfile.Size = new System.Drawing.Size(127, 23);
            this.createProfile.TabIndex = 2;
            this.createProfile.Text = "Create Profile";
            this.createProfile.UseVisualStyleBackColor = true;
            this.createProfile.Click += new System.EventHandler(this.CreateProfile_Click);
            // 
            // profileSelector
            // 
            this.profileSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profileSelector.FormattingEnabled = true;
            this.profileSelector.Location = new System.Drawing.Point(12, 41);
            this.profileSelector.Name = "profileSelector";
            this.profileSelector.Size = new System.Drawing.Size(606, 23);
            this.profileSelector.TabIndex = 1;
            // 
            // loadProfile
            // 
            this.loadProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadProfile.Location = new System.Drawing.Point(624, 40);
            this.loadProfile.Name = "loadProfile";
            this.loadProfile.Size = new System.Drawing.Size(127, 23);
            this.loadProfile.TabIndex = 0;
            this.loadProfile.Text = "Load Profile";
            this.loadProfile.UseVisualStyleBackColor = true;
            // 
            // armaFolderUpdate
            // 
            this.armaFolderUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.armaFolderUpdate.Location = new System.Drawing.Point(624, 2);
            this.armaFolderUpdate.Name = "armaFolderUpdate";
            this.armaFolderUpdate.Size = new System.Drawing.Size(127, 23);
            this.armaFolderUpdate.TabIndex = 6;
            this.armaFolderUpdate.Text = "Update Mod Folder";
            this.armaFolderUpdate.UseVisualStyleBackColor = true;
            // 
            // armaFolderDisplay
            // 
            this.armaFolderDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armaFolderDisplay.Location = new System.Drawing.Point(12, 3);
            this.armaFolderDisplay.Name = "armaFolderDisplay";
            this.armaFolderDisplay.ReadOnly = true;
            this.armaFolderDisplay.Size = new System.Drawing.Size(606, 23);
            this.armaFolderDisplay.TabIndex = 5;
            // 
            // modTabs
            // 
            this.modTabs.Controls.Add(this.requiredMods);
            this.modTabs.Controls.Add(this.whitelistMods);
            this.modTabs.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modTabs.Location = new System.Drawing.Point(0, 0);
            this.modTabs.Name = "modTabs";
            this.modTabs.SelectedIndex = 0;
            this.modTabs.Size = new System.Drawing.Size(358, 491);
            this.modTabs.TabIndex = 0;
            // 
            // requiredMods
            // 
            this.requiredMods.Controls.Add(this.modlistBox);
            this.requiredMods.Controls.Add(this.updateMods);
            this.requiredMods.Location = new System.Drawing.Point(4, 24);
            this.requiredMods.Name = "requiredMods";
            this.requiredMods.Padding = new System.Windows.Forms.Padding(3);
            this.requiredMods.Size = new System.Drawing.Size(350, 463);
            this.requiredMods.TabIndex = 0;
            this.requiredMods.Text = "Required Mods";
            this.requiredMods.UseVisualStyleBackColor = true;
            // 
            // modlistBox
            // 
            this.modlistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modlistBox.FormattingEnabled = true;
            this.modlistBox.ItemHeight = 15;
            this.modlistBox.Location = new System.Drawing.Point(3, 26);
            this.modlistBox.Name = "modlistBox";
            this.modlistBox.Size = new System.Drawing.Size(344, 434);
            this.modlistBox.TabIndex = 1;
            // 
            // updateMods
            // 
            this.updateMods.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateMods.Location = new System.Drawing.Point(3, 3);
            this.updateMods.Name = "updateMods";
            this.updateMods.Size = new System.Drawing.Size(344, 23);
            this.updateMods.TabIndex = 0;
            this.updateMods.Text = "Update Mods";
            this.updateMods.UseVisualStyleBackColor = true;
            // 
            // whitelistMods
            // 
            this.whitelistMods.Controls.Add(this.whitelistBox);
            this.whitelistMods.Controls.Add(this.updateWhitelist);
            this.whitelistMods.Location = new System.Drawing.Point(4, 24);
            this.whitelistMods.Name = "whitelistMods";
            this.whitelistMods.Padding = new System.Windows.Forms.Padding(3);
            this.whitelistMods.Size = new System.Drawing.Size(350, 463);
            this.whitelistMods.TabIndex = 1;
            this.whitelistMods.Text = "Whitelist Mods";
            this.whitelistMods.UseVisualStyleBackColor = true;
            // 
            // whitelistBox
            // 
            this.whitelistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whitelistBox.FormattingEnabled = true;
            this.whitelistBox.Location = new System.Drawing.Point(3, 26);
            this.whitelistBox.Name = "whitelistBox";
            this.whitelistBox.Size = new System.Drawing.Size(344, 434);
            this.whitelistBox.TabIndex = 1;
            // 
            // updateWhitelist
            // 
            this.updateWhitelist.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateWhitelist.Location = new System.Drawing.Point(3, 3);
            this.updateWhitelist.Name = "updateWhitelist";
            this.updateWhitelist.Size = new System.Drawing.Size(344, 23);
            this.updateWhitelist.TabIndex = 0;
            this.updateWhitelist.Text = "Update Whitelist";
            this.updateWhitelist.UseVisualStyleBackColor = true;
            // 
            // primaryMenu
            // 
            this.primaryMenu.Location = new System.Drawing.Point(0, 0);
            this.primaryMenu.Name = "primaryMenu";
            this.primaryMenu.Size = new System.Drawing.Size(1116, 24);
            this.primaryMenu.TabIndex = 2;
            this.primaryMenu.Text = "menuStrip1";
            // 
            // ClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 537);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.primaryStatus);
            this.Controls.Add(this.primaryMenu);
            this.MainMenuStrip = this.primaryMenu;
            this.Name = "ClientMain";
            this.Text = "ClientMain";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.modSyncBox.ResumeLayout(false);
            this.modSyncBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syncPort)).EndInit();
            this.modTabs.ResumeLayout(false);
            this.requiredMods.ResumeLayout(false);
            this.whitelistMods.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private StatusStrip primaryStatus;
    private SplitContainer splitContainer1;
    private SplitContainer splitContainer2;
    private ComboBox profileSelector;
    private Button loadProfile;
    private MenuStrip primaryMenu;
    private Button createProfile;
    private FolderBrowserDialog folderSelectDialog;
    private Button updateModFolder;
    private TextBox modFolderPathDisplay;
    private TabControl modTabs;
    private TabPage requiredMods;
    private TabPage whitelistMods;
    private GroupBox modSyncBox;
    private Button updateWhitelist;
    private Button updateMods;
    private CheckBox syncOnLaunch;
    private Label label4;
    private TextBox syncPassword;
    private Label label3;
    private TextBox syncUsername;
    private NumericUpDown syncPort;
    private Label label2;
    private Label label1;
    private TextBox syncServer;
    private Button importProfile;
    private Button exportProfile;
    private CheckedListBox whitelistBox;
    private ListBox modlistBox;
    private Button saveChanges;
    private Button testConnection;
    private Button armaFolderUpdate;
    private TextBox armaFolderDisplay;
    private Button syncAllMods;
}
