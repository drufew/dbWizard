namespace dbWizard
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.GroupBoxTools = new System.Windows.Forms.GroupBox();
            this.btn_OpenTable = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToNewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDbWizardDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_ConnectionString = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.lbl_User = new System.Windows.Forms.Label();
            this.ttOpenTable = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Fullrestore = new System.Windows.Forms.Button();
            this.btn_PartialRestore = new System.Windows.Forms.Button();
            this.btn_BulkUpdate = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_QueryEditor = new System.Windows.Forms.Button();
            this.btn_OtherUsers = new System.Windows.Forms.Button();
            this.btn_DeleteData = new System.Windows.Forms.Button();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxTools.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxTools
            // 
            this.GroupBoxTools.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxTools.Controls.Add(this.btn_Export);
            this.GroupBoxTools.Controls.Add(this.btn_Backup);
            this.GroupBoxTools.Controls.Add(this.btn_DeleteData);
            this.GroupBoxTools.Controls.Add(this.btn_OtherUsers);
            this.GroupBoxTools.Controls.Add(this.btn_QueryEditor);
            this.GroupBoxTools.Controls.Add(this.btn_Import);
            this.GroupBoxTools.Controls.Add(this.btn_BulkUpdate);
            this.GroupBoxTools.Controls.Add(this.btn_PartialRestore);
            this.GroupBoxTools.Controls.Add(this.btn_Fullrestore);
            this.GroupBoxTools.Controls.Add(this.btn_OpenTable);
            this.GroupBoxTools.Location = new System.Drawing.Point(1210, 60);
            this.GroupBoxTools.Name = "GroupBoxTools";
            this.GroupBoxTools.Size = new System.Drawing.Size(43, 599);
            this.GroupBoxTools.TabIndex = 2;
            this.GroupBoxTools.TabStop = false;
            // 
            // btn_OpenTable
            // 
            this.btn_OpenTable.BackColor = System.Drawing.Color.Transparent;
            this.btn_OpenTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OpenTable.BackgroundImage")));
            this.btn_OpenTable.Location = new System.Drawing.Point(8, 19);
            this.btn_OpenTable.Name = "btn_OpenTable";
            this.btn_OpenTable.Size = new System.Drawing.Size(29, 28);
            this.btn_OpenTable.TabIndex = 5;
            this.btn_OpenTable.UseVisualStyleBackColor = false;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.MenuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1260, 24);
            this.MenuStrip.Stretch = false;
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.logInToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("importToolStripMenuItem.Image")));
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportToolStripMenuItem.Image")));
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logInToolStripMenuItem.Image")));
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logInToolStripMenuItem.Text = "Log in";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colourSchemeToolStripMenuItem,
            this.connectionsToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // colourSchemeToolStripMenuItem
            // 
            this.colourSchemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.colourSchemeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colourSchemeToolStripMenuItem.Image")));
            this.colourSchemeToolStripMenuItem.Name = "colourSchemeToolStripMenuItem";
            this.colourSchemeToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.colourSchemeToolStripMenuItem.Text = "Colour Scheme";
            this.colourSchemeToolStripMenuItem.Click += new System.EventHandler(this.colourSchemeToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToNewDatabaseToolStripMenuItem,
            this.connectionStringToolStripMenuItem});
            this.connectionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectionsToolStripMenuItem.Image")));
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.connectionsToolStripMenuItem.Text = "Connections";
            this.connectionsToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // connectToNewDatabaseToolStripMenuItem
            // 
            this.connectToNewDatabaseToolStripMenuItem.Name = "connectToNewDatabaseToolStripMenuItem";
            this.connectToNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.connectToNewDatabaseToolStripMenuItem.Text = "Connect to new database";
            this.connectToNewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.connectToNewDatabaseToolStripMenuItem_Click);
            // 
            // connectionStringToolStripMenuItem
            // 
            this.connectionStringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem,
            this.showToolStripMenuItem});
            this.connectionStringToolStripMenuItem.Name = "connectionStringToolStripMenuItem";
            this.connectionStringToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.connectionStringToolStripMenuItem.Text = "Connection String";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDbWizardDatabaseToolStripMenuItem});
            this.setupToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setupToolStripMenuItem.Image")));
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.setupToolStripMenuItem.Text = "Setup";
            this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
            // 
            // createDbWizardDatabaseToolStripMenuItem
            // 
            this.createDbWizardDatabaseToolStripMenuItem.Name = "createDbWizardDatabaseToolStripMenuItem";
            this.createDbWizardDatabaseToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.createDbWizardDatabaseToolStripMenuItem.Text = "Create dbWizard database";
            this.createDbWizardDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createDbWizardDatabaseToolStripMenuItem_Click);
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.viewsToolStripMenuItem.Text = "Views";
            this.viewsToolStripMenuItem.Click += new System.EventHandler(this.viewsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolBarToolStripMenuItem,
            this.closeToolBarToolStripMenuItem});
            this.toolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolsToolStripMenuItem.Image")));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // openToolBarToolStripMenuItem
            // 
            this.openToolBarToolStripMenuItem.Name = "openToolBarToolStripMenuItem";
            this.openToolBarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.openToolBarToolStripMenuItem.Text = "Open tool bar";
            this.openToolBarToolStripMenuItem.Click += new System.EventHandler(this.openToolBarToolStripMenuItem_Click);
            // 
            // closeToolBarToolStripMenuItem
            // 
            this.closeToolBarToolStripMenuItem.Name = "closeToolBarToolStripMenuItem";
            this.closeToolBarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.closeToolBarToolStripMenuItem.Text = "Close tool bar";
            this.closeToolBarToolStripMenuItem.Click += new System.EventHandler(this.closeToolBarToolStripMenuItem_Click);
            // 
            // lbl_ConnectionString
            // 
            this.lbl_ConnectionString.AutoSize = true;
            this.lbl_ConnectionString.Location = new System.Drawing.Point(6, 646);
            this.lbl_ConnectionString.Name = "lbl_ConnectionString";
            this.lbl_ConnectionString.Size = new System.Drawing.Size(105, 13);
            this.lbl_ConnectionString.TabIndex = 4;
            this.lbl_ConnectionString.Text = "No connection string";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 10;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(1055, 646);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(116, 13);
            this.lbl_User.TabIndex = 5;
            this.lbl_User.Text = "Not currently logged in.";
            // 
            // ttOpenTable
            // 
            this.ttOpenTable.IsBalloon = true;
            this.ttOpenTable.Popup += new System.Windows.Forms.PopupEventHandler(this.ttOpenTable_Popup);
            // 
            // btn_Fullrestore
            // 
            this.btn_Fullrestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Fullrestore.BackgroundImage")));
            this.btn_Fullrestore.Location = new System.Drawing.Point(8, 53);
            this.btn_Fullrestore.Name = "btn_Fullrestore";
            this.btn_Fullrestore.Size = new System.Drawing.Size(29, 28);
            this.btn_Fullrestore.TabIndex = 6;
            this.btn_Fullrestore.UseVisualStyleBackColor = true;
            this.btn_Fullrestore.Click += new System.EventHandler(this.btn_Fullrestore_Click);
            // 
            // btn_PartialRestore
            // 
            this.btn_PartialRestore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_PartialRestore.BackgroundImage")));
            this.btn_PartialRestore.Location = new System.Drawing.Point(8, 87);
            this.btn_PartialRestore.Name = "btn_PartialRestore";
            this.btn_PartialRestore.Size = new System.Drawing.Size(29, 28);
            this.btn_PartialRestore.TabIndex = 6;
            this.btn_PartialRestore.UseVisualStyleBackColor = true;
            // 
            // btn_BulkUpdate
            // 
            this.btn_BulkUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BulkUpdate.BackgroundImage")));
            this.btn_BulkUpdate.Location = new System.Drawing.Point(8, 121);
            this.btn_BulkUpdate.Name = "btn_BulkUpdate";
            this.btn_BulkUpdate.Size = new System.Drawing.Size(29, 28);
            this.btn_BulkUpdate.TabIndex = 6;
            this.btn_BulkUpdate.UseVisualStyleBackColor = true;
            // 
            // btn_Import
            // 
            this.btn_Import.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Import.BackgroundImage")));
            this.btn_Import.Location = new System.Drawing.Point(8, 155);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(29, 28);
            this.btn_Import.TabIndex = 6;
            this.btn_Import.UseVisualStyleBackColor = true;
            // 
            // btn_QueryEditor
            // 
            this.btn_QueryEditor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_QueryEditor.BackgroundImage")));
            this.btn_QueryEditor.Location = new System.Drawing.Point(8, 189);
            this.btn_QueryEditor.Name = "btn_QueryEditor";
            this.btn_QueryEditor.Size = new System.Drawing.Size(29, 28);
            this.btn_QueryEditor.TabIndex = 6;
            this.btn_QueryEditor.UseVisualStyleBackColor = true;
            // 
            // btn_OtherUsers
            // 
            this.btn_OtherUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OtherUsers.BackgroundImage")));
            this.btn_OtherUsers.Location = new System.Drawing.Point(8, 563);
            this.btn_OtherUsers.Name = "btn_OtherUsers";
            this.btn_OtherUsers.Size = new System.Drawing.Size(29, 28);
            this.btn_OtherUsers.TabIndex = 6;
            this.btn_OtherUsers.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteData
            // 
            this.btn_DeleteData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DeleteData.BackgroundImage")));
            this.btn_DeleteData.Location = new System.Drawing.Point(8, 223);
            this.btn_DeleteData.Name = "btn_DeleteData";
            this.btn_DeleteData.Size = new System.Drawing.Size(29, 28);
            this.btn_DeleteData.TabIndex = 6;
            this.btn_DeleteData.UseVisualStyleBackColor = true;
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Backup.BackgroundImage")));
            this.btn_Backup.Location = new System.Drawing.Point(8, 257);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(29, 28);
            this.btn_Backup.TabIndex = 6;
            this.btn_Backup.UseVisualStyleBackColor = true;
            // 
            // btn_Export
            // 
            this.btn_Export.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Export.BackgroundImage")));
            this.btn_Export.Location = new System.Drawing.Point(8, 291);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(29, 28);
            this.btn_Export.TabIndex = 6;
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.usersToolStripMenuItem.Text = "Manage users (admin only)";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 663);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_ConnectionString);
            this.Controls.Add(this.GroupBoxTools);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Sizable = false;
            this.Text = "db.Wizard 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxTools.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToNewDatabaseToolStripMenuItem;
        public System.Windows.Forms.Label lbl_ConnectionString;
        public System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.ToolStripMenuItem connectionStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDbWizardDatabaseToolStripMenuItem;
        private System.Windows.Forms.Button btn_OpenTable;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        public System.Windows.Forms.Label lbl_User;
        public System.Windows.Forms.MenuStrip MenuStrip;
        public System.Windows.Forms.GroupBox GroupBoxTools;
        public System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttOpenTable;
        private System.Windows.Forms.Button btn_Fullrestore;
        private System.Windows.Forms.Button btn_PartialRestore;
        private System.Windows.Forms.Button btn_BulkUpdate;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_QueryEditor;
        private System.Windows.Forms.Button btn_OtherUsers;
        private System.Windows.Forms.Button btn_DeleteData;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}

