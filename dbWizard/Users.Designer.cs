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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.tbUserList = new System.Windows.Forms.TabPage();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.tbUsers = new System.Windows.Forms.TabControl();
            this.gb_UserData = new System.Windows.Forms.GroupBox();
            this.lbl_Fullname = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btn_SaveChanges = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_Saved = new System.Windows.Forms.Label();
            this.pb_Saved = new System.Windows.Forms.PictureBox();
            this.tbUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.tbUsers.SuspendLayout();
            this.gb_UserData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Saved)).BeginInit();
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
            this.tbUsers.Location = new System.Drawing.Point(12, 70);
            this.tbUsers.Name = "tbUsers";
            this.tbUsers.SelectedIndex = 0;
            this.tbUsers.Size = new System.Drawing.Size(662, 474);
            this.tbUsers.TabIndex = 0;
            // 
            // gb_UserData
            // 
            this.gb_UserData.BackColor = System.Drawing.Color.Transparent;
            this.gb_UserData.Controls.Add(this.pb_Saved);
            this.gb_UserData.Controls.Add(this.lbl_Saved);
            this.gb_UserData.Controls.Add(this.btn_SaveChanges);
            this.gb_UserData.Controls.Add(this.label5);
            this.gb_UserData.Controls.Add(this.txtCountry);
            this.gb_UserData.Controls.Add(this.label4);
            this.gb_UserData.Controls.Add(this.txtEmail);
            this.gb_UserData.Controls.Add(this.label3);
            this.gb_UserData.Controls.Add(this.txtDOB);
            this.gb_UserData.Controls.Add(this.label2);
            this.gb_UserData.Controls.Add(this.txtSurname);
            this.gb_UserData.Controls.Add(this.label1);
            this.gb_UserData.Controls.Add(this.txtForename);
            this.gb_UserData.Controls.Add(this.lbl_Fullname);
            this.gb_UserData.Location = new System.Drawing.Point(680, 84);
            this.gb_UserData.Name = "gb_UserData";
            this.gb_UserData.Size = new System.Drawing.Size(249, 460);
            this.gb_UserData.TabIndex = 1;
            this.gb_UserData.TabStop = false;
            this.gb_UserData.Text = "Information";
            this.gb_UserData.Enter += new System.EventHandler(this.gb_UserData_Enter);
            // 
            // lbl_Fullname
            // 
            this.lbl_Fullname.AutoSize = true;
            this.lbl_Fullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fullname.Location = new System.Drawing.Point(6, 16);
            this.lbl_Fullname.Name = "lbl_Fullname";
            this.lbl_Fullname.Size = new System.Drawing.Size(100, 25);
            this.lbl_Fullname.TabIndex = 0;
            this.lbl_Fullname.Text = "Fullname";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(11, 78);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(232, 20);
            this.txtForename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(11, 123);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(232, 20);
            this.txtSurname.TabIndex = 3;
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
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(11, 170);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(232, 20);
            this.txtDOB.TabIndex = 5;
            this.txtDOB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 216);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Country";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(11, 263);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(232, 20);
            this.txtCountry.TabIndex = 9;
            // 
            // btn_SaveChanges
            // 
            this.btn_SaveChanges.Depth = 0;
            this.btn_SaveChanges.Location = new System.Drawing.Point(11, 427);
            this.btn_SaveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SaveChanges.Name = "btn_SaveChanges";
            this.btn_SaveChanges.Primary = true;
            this.btn_SaveChanges.Size = new System.Drawing.Size(127, 23);
            this.btn_SaveChanges.TabIndex = 11;
            this.btn_SaveChanges.Text = "Save Changes";
            this.btn_SaveChanges.UseVisualStyleBackColor = true;
            this.btn_SaveChanges.Click += new System.EventHandler(this.btn_SaveChanges_Click);
            // 
            // lbl_Saved
            // 
            this.lbl_Saved.AutoSize = true;
            this.lbl_Saved.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saved.Location = new System.Drawing.Point(60, 286);
            this.lbl_Saved.Name = "lbl_Saved";
            this.lbl_Saved.Size = new System.Drawing.Size(135, 13);
            this.lbl_Saved.TabIndex = 13;
            this.lbl_Saved.Text = "Changes have been saved";
            this.lbl_Saved.Visible = false;
            // 
            // pb_Saved
            // 
            this.pb_Saved.Image = ((System.Drawing.Image)(resources.GetObject("pb_Saved.Image")));
            this.pb_Saved.Location = new System.Drawing.Point(116, 302);
            this.pb_Saved.Name = "pb_Saved";
            this.pb_Saved.Size = new System.Drawing.Size(29, 31);
            this.pb_Saved.TabIndex = 14;
            this.pb_Saved.TabStop = false;
            this.pb_Saved.Visible = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 556);
            this.Controls.Add(this.gb_UserData);
            this.Controls.Add(this.tbUsers);
            this.MaximizeBox = false;
            this.Name = "Users";
            this.Sizable = false;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.tbUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.tbUsers.ResumeLayout(false);
            this.gb_UserData.ResumeLayout(false);
            this.gb_UserData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Saved)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbUserList;
        private System.Windows.Forms.TabControl tbUsers;
        private System.Windows.Forms.GroupBox gb_UserData;
        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lbl_Fullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountry;
        private MaterialSkin.Controls.MaterialRaisedButton btn_SaveChanges;
        private System.Windows.Forms.PictureBox pb_Saved;
        private System.Windows.Forms.Label lbl_Saved;
    }
}