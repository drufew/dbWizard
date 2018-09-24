namespace dbWizard
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.tbUserList = new System.Windows.Forms.TabPage();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.tbUsers = new System.Windows.Forms.TabControl();
            this.tbUserGroups = new System.Windows.Forms.TabPage();
            this.dgv_SecurityGroups = new System.Windows.Forms.DataGridView();
            this.gb_UserData = new System.Windows.Forms.GroupBox();
            this.cmb_SecurityGroups = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pb_Offline = new System.Windows.Forms.PictureBox();
            this.pb_Online = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pb_Saved = new System.Windows.Forms.PictureBox();
            this.lbl_Saved = new System.Windows.Forms.Label();
            this.btn_SaveChanges = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lbl_Fullname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_UserOptions = new System.Windows.Forms.ComboBox();
            this.UsersMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.securityGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tbUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.tbUsers.SuspendLayout();
            this.tbUserGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SecurityGroups)).BeginInit();
            this.gb_UserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Offline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Online)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Saved)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.UsersMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserList
            // 
            this.tbUserList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUserList.Controls.Add(this.dgv_Users);
            this.tbUserList.Location = new System.Drawing.Point(4, 22);
            this.tbUserList.Name = "tbUserList";
            this.tbUserList.Padding = new System.Windows.Forms.Padding(3);
            this.tbUserList.Size = new System.Drawing.Size(654, 448);
            this.tbUserList.TabIndex = 0;
            this.tbUserList.Text = "Users";
            this.tbUserList.UseVisualStyleBackColor = true;
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            this.dgv_Users.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Users.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Users.Location = new System.Drawing.Point(6, 6);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Users.Size = new System.Drawing.Size(642, 436);
            this.dgv_Users.TabIndex = 0;
            this.dgv_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellContentClick);
            this.dgv_Users.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Users_RowHeaderMouseClick);
            // 
            // tbUsers
            // 
            this.tbUsers.Controls.Add(this.tbUserList);
            this.tbUsers.Controls.Add(this.tbUserGroups);
            this.tbUsers.Location = new System.Drawing.Point(12, 70);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.SelectedIndex = 0;
            this.tbUsers.Size = new System.Drawing.Size(662, 474);
            this.tbUsers.TabIndex = 0;
            this.tbUsers.SelectedIndexChanged += new System.EventHandler(this.tbUsers_SelectedIndexChanged);
            // 
            // tbUserGroups
            // 
            this.tbUserGroups.Controls.Add(this.dgv_SecurityGroups);
            this.tbUserGroups.Location = new System.Drawing.Point(4, 22);
            this.tbUserGroups.Name = "tbUserGroups";
            this.tbUserGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tbUserGroups.Size = new System.Drawing.Size(654, 448);
            this.tbUserGroups.TabIndex = 1;
            this.tbUserGroups.Text = "Security Groups";
            this.tbUserGroups.UseVisualStyleBackColor = true;
            // 
            // dgv_SecurityGroups
            // 
            this.dgv_SecurityGroups.AllowUserToAddRows = false;
            this.dgv_SecurityGroups.AllowUserToDeleteRows = false;
            this.dgv_SecurityGroups.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_SecurityGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SecurityGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_SecurityGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SecurityGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SecurityGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SecurityGroups.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_SecurityGroups.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_SecurityGroups.Location = new System.Drawing.Point(6, 6);
            this.dgv_SecurityGroups.Name = "dgv_SecurityGroups";
            this.dgv_SecurityGroups.ReadOnly = true;
            this.dgv_SecurityGroups.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SecurityGroups.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_SecurityGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SecurityGroups.Size = new System.Drawing.Size(642, 436);
            this.dgv_SecurityGroups.TabIndex = 1;
            // 
            // gb_UserData
            // 
            this.gb_UserData.BackColor = System.Drawing.Color.Transparent;
            this.gb_UserData.Controls.Add(this.dtBirthDate);
            this.gb_UserData.Controls.Add(this.cmb_SecurityGroups);
            this.gb_UserData.Controls.Add(this.label8);
            this.gb_UserData.Controls.Add(this.pb_Offline);
            this.gb_UserData.Controls.Add(this.pb_Online);
            this.gb_UserData.Controls.Add(this.label6);
            this.gb_UserData.Controls.Add(this.pb_Saved);
            this.gb_UserData.Controls.Add(this.lbl_Saved);
            this.gb_UserData.Controls.Add(this.btn_SaveChanges);
            this.gb_UserData.Controls.Add(this.label5);
            this.gb_UserData.Controls.Add(this.txtCountry);
            this.gb_UserData.Controls.Add(this.label4);
            this.gb_UserData.Controls.Add(this.txtEmail);
            this.gb_UserData.Controls.Add(this.label3);
            this.gb_UserData.Controls.Add(this.label2);
            this.gb_UserData.Controls.Add(this.txtSurname);
            this.gb_UserData.Controls.Add(this.label1);
            this.gb_UserData.Controls.Add(this.txtForename);
            this.gb_UserData.Controls.Add(this.lbl_Fullname);
            this.gb_UserData.Location = new System.Drawing.Point(680, 84);
            this.gb_UserData.Name = "gb_UserData";
            this.gb_UserData.Size = new System.Drawing.Size(249, 385);
            this.gb_UserData.TabIndex = 1;
            this.gb_UserData.TabStop = false;
            this.gb_UserData.Text = "Information";
            this.gb_UserData.Enter += new System.EventHandler(this.gb_UserData_Enter);
            // 
            // cmb_SecurityGroups
            // 
            this.cmb_SecurityGroups.FormattingEnabled = true;
            this.cmb_SecurityGroups.Location = new System.Drawing.Point(11, 287);
            this.cmb_SecurityGroups.Name = "cmb_SecurityGroups";
            this.cmb_SecurityGroups.Size = new System.Drawing.Size(232, 21);
            this.cmb_SecurityGroups.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Security Group";
            // 
            // pb_Offline
            // 
            this.pb_Offline.Image = ((System.Drawing.Image)(resources.GetObject("pb_Offline.Image")));
            this.pb_Offline.Location = new System.Drawing.Point(125, 41);
            this.pb_Offline.Name = "pb_Offline";
            this.pb_Offline.Size = new System.Drawing.Size(28, 32);
            this.pb_Offline.TabIndex = 17;
            this.pb_Offline.TabStop = false;
            this.pb_Offline.Visible = false;
            // 
            // pb_Online
            // 
            this.pb_Online.Image = ((System.Drawing.Image)(resources.GetObject("pb_Online.Image")));
            this.pb_Online.Location = new System.Drawing.Point(125, 41);
            this.pb_Online.Name = "pb_Online";
            this.pb_Online.Size = new System.Drawing.Size(21, 21);
            this.pb_Online.TabIndex = 16;
            this.pb_Online.TabStop = false;
            this.pb_Online.Visible = false;
            this.pb_Online.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Availability:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pb_Saved
            // 
            this.pb_Saved.Image = ((System.Drawing.Image)(resources.GetObject("pb_Saved.Image")));
            this.pb_Saved.Location = new System.Drawing.Point(169, 326);
            this.pb_Saved.Name = "pb_Saved";
            this.pb_Saved.Size = new System.Drawing.Size(29, 31);
            this.pb_Saved.TabIndex = 14;
            this.pb_Saved.TabStop = false;
            this.pb_Saved.Visible = false;
            // 
            // lbl_Saved
            // 
            this.lbl_Saved.AutoSize = true;
            this.lbl_Saved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saved.Location = new System.Drawing.Point(105, 310);
            this.lbl_Saved.Name = "lbl_Saved";
            this.lbl_Saved.Size = new System.Drawing.Size(135, 13);
            this.lbl_Saved.TabIndex = 13;
            this.lbl_Saved.Text = "Changes have been saved";
            this.lbl_Saved.Visible = false;
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Depth = 0;
            this.btn_SaveChanges.Location = new System.Drawing.Point(11, 354);
            this.btn_SaveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Primary = true;
            this.btn_SaveChanges.Size = new System.Drawing.Size(127, 23);
            this.btn_SaveChanges.TabIndex = 11;
            this.btn_SaveChanges.Text = "Save Changes";
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(11, 247);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(232, 20);
            this.txtCountry.TabIndex = 9;
            this.txtCountry.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            this.txtCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCountry_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date of Birth";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(11, 131);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(232, 20);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSurname_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forename";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(11, 93);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(232, 20);
            this.txtForename.TabIndex = 1;
            this.txtForename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtForename_KeyDown);
            // 
            // lbl_Fullname
            // 
            this.lbl_Fullname.AutoSize = true;
            this.lbl_Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fullname.Location = new System.Drawing.Point(58, 16);
            this.lbl_Fullname.Name = "lbl_Fullname";
            this.lbl_Fullname.Size = new System.Drawing.Size(100, 25);
            this.lbl_Fullname.TabIndex = 0;
            this.lbl_Fullname.Text = "Fullname";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_UserOptions);
            this.groupBox1.Location = new System.Drawing.Point(680, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Options for selected rows:";
            // 
            // cmb_UserOptions
            // 
            this.cmb_UserOptions.FormattingEnabled = true;
            this.cmb_UserOptions.Items.AddRange(new object[] {
            "Export selected users",
            "Delete selected users",
            "Reset passwords (via email, defaults to \'letmein\')"});
            this.cmb_UserOptions.Location = new System.Drawing.Point(6, 33);
            this.cmb_UserOptions.Name = "cmb_UserOptions";
            this.cmb_UserOptions.Size = new System.Drawing.Size(237, 21);
            this.cmb_UserOptions.TabIndex = 0;
            this.cmb_UserOptions.SelectedIndexChanged += new System.EventHandler(this.cmb_UserOptions_SelectedIndexChanged);
            // 
            // UsersMenuStrip
            // 
            this.UsersMenuStrip.BackColor = System.Drawing.Color.Transparent;
            this.UsersMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.addNewUserToolStripMenuItem1});
            this.UsersMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.UsersMenuStrip.Name = "UsersMenuStrip";
            this.UsersMenuStrip.Size = new System.Drawing.Size(941, 24);
            this.UsersMenuStrip.TabIndex = 3;
            this.UsersMenuStrip.Text = "menuStrip1";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.addNewUserToolStripMenuItem.Text = "Close";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem1
            // 
            this.addNewUserToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.securityGroupToolStripMenuItem});
            this.addNewUserToolStripMenuItem1.Name = "addNewUserToolStripMenuItem1";
            this.addNewUserToolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.addNewUserToolStripMenuItem1.Text = "Add new..";
            this.addNewUserToolStripMenuItem1.Click += new System.EventHandler(this.addNewUserToolStripMenuItem1_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // securityGroupToolStripMenuItem
            // 
            this.securityGroupToolStripMenuItem.Name = "securityGroupToolStripMenuItem";
            this.securityGroupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.securityGroupToolStripMenuItem.Text = "Security Group";
            this.securityGroupToolStripMenuItem.Click += new System.EventHandler(this.securityGroupToolStripMenuItem_Click);
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(11, 170);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(232, 20);
            this.dtBirthDate.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_UserData);
            this.Controls.Add(this.tbUsers);
            this.Controls.Add(this.UsersMenuStrip);
            this.MainMenuStrip = this.UsersMenuStrip;
            this.MaximizeBox = false;
            this.Name = "Users";
            this.Sizable = false;
            this.Text = "User Configuration";
            this.Load += new System.EventHandler(this.Users_Load);
            this.tbUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.tbUsers.ResumeLayout(false);
            this.tbUserGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SecurityGroups)).EndInit();
            this.gb_UserData.ResumeLayout(false);
            this.gb_UserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Offline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Online)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Saved)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UsersMenuStrip.ResumeLayout(false);
            this.UsersMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tbUserList;
        private System.Windows.Forms.TabControl tbUsers;
        private System.Windows.Forms.GroupBox gb_UserData;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lbl_Fullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountry;
        private MaterialSkin.Controls.MaterialRaisedButton btn_SaveChanges;
        private System.Windows.Forms.PictureBox pb_Saved;
        private System.Windows.Forms.Label lbl_Saved;
        private System.Windows.Forms.PictureBox pb_Online;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pb_Offline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_UserOptions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip UsersMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem securityGroupToolStripMenuItem;
        private System.Windows.Forms.TabPage tbUserGroups;
        private System.Windows.Forms.DataGridView dgv_SecurityGroups;
        private System.Windows.Forms.ComboBox cmb_SecurityGroups;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox txtEmail;
    }
}