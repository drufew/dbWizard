namespace dbWizard
{
    partial class ConnectionDetails
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
            this.txtServerAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtConnectToServer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateCon = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Depth = 0;
            this.txtServerAddress.Hint = "";
            this.txtServerAddress.Location = new System.Drawing.Point(12, 88);
            this.txtServerAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.PasswordChar = '\0';
            this.txtServerAddress.SelectedText = "";
            this.txtServerAddress.SelectionLength = 0;
            this.txtServerAddress.SelectionStart = 0;
            this.txtServerAddress.Size = new System.Drawing.Size(321, 23);
            this.txtServerAddress.TabIndex = 1;
            this.txtServerAddress.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Depth = 0;
            this.txtUser.Hint = "";
            this.txtUser.Location = new System.Drawing.Point(12, 142);
            this.txtUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.Size = new System.Drawing.Size(321, 23);
            this.txtUser.TabIndex = 9;
            this.txtUser.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Depth = 0;
            this.txtPassword.Hint = "";
            this.txtPassword.Location = new System.Drawing.Point(12, 197);
            this.txtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.Size = new System.Drawing.Size(284, 23);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtConnectToServer
            // 
            this.txtConnectToServer.Depth = 0;
            this.txtConnectToServer.Location = new System.Drawing.Point(302, 197);
            this.txtConnectToServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConnectToServer.Name = "txtConnectToServer";
            this.txtConnectToServer.Primary = true;
            this.txtConnectToServer.Size = new System.Drawing.Size(31, 23);
            this.txtConnectToServer.TabIndex = 12;
            this.txtConnectToServer.Text = "Go";
            this.txtConnectToServer.UseVisualStyleBackColor = true;
            this.txtConnectToServer.Click += new System.EventHandler(this.txtConnectToServer_Click);
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(12, 253);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(321, 21);
            this.cmbSource.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Target DB";
            // 
            // btnCreateCon
            // 
            this.btnCreateCon.AutoSize = true;
            this.btnCreateCon.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateCon.Depth = 0;
            this.btnCreateCon.Location = new System.Drawing.Point(12, 316);
            this.btnCreateCon.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCreateCon.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCreateCon.Name = "btnCreateCon";
            this.btnCreateCon.Primary = false;
            this.btnCreateCon.Size = new System.Drawing.Size(173, 36);
            this.btnCreateCon.TabIndex = 15;
            this.btnCreateCon.Text = "Establish Connection";
            this.btnCreateCon.UseVisualStyleBackColor = true;
            this.btnCreateCon.Click += new System.EventHandler(this.btnCreateCon_Click);
            // 
            // ConnectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 367);
            this.Controls.Add(this.btnCreateCon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSource);
            this.Controls.Add(this.txtConnectToServer);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServerAddress);
            this.MaximizeBox = false;
            this.Name = "ConnectionDetails";
            this.Sizable = false;
            this.Text = "Connection Details";
            this.Load += new System.EventHandler(this.ConnectionDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServerAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUser;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton txtConnectToServer;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialFlatButton btnCreateCon;
    }
}