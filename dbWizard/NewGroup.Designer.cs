namespace dbWizard
{
    partial class NewGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGroupName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Security = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Alias";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Depth = 0;
            this.txtGroupName.Hint = "";
            this.txtGroupName.Location = new System.Drawing.Point(15, 100);
            this.txtGroupName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.PasswordChar = '\0';
            this.txtGroupName.SelectedText = "";
            this.txtGroupName.SelectionLength = 0;
            this.txtGroupName.SelectionStart = 0;
            this.txtGroupName.Size = new System.Drawing.Size(450, 23);
            this.txtGroupName.TabIndex = 1;
            this.txtGroupName.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group Security";
            // 
            // cmb_Security
            // 
            this.cmb_Security.FormattingEnabled = true;
            this.cmb_Security.Items.AddRange(new object[] {
            "None",
            "Read",
            "Write",
            "All"});
            this.cmb_Security.Location = new System.Drawing.Point(15, 152);
            this.cmb_Security.Name = "cmb_Security";
            this.cmb_Security.Size = new System.Drawing.Size(450, 21);
            this.cmb_Security.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.AutoSize = true;
            this.btn_Submit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Submit.Depth = 0;
            this.btn_Submit.Location = new System.Drawing.Point(15, 248);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Submit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Primary = false;
            this.btn_Submit.Size = new System.Drawing.Size(62, 36);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // NewGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 294);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cmb_Security);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "NewGroup";
            this.Sizable = false;
            this.Text = "Add New Group";
            this.Load += new System.EventHandler(this.NewGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Security;
        private MaterialSkin.Controls.MaterialFlatButton btn_Submit;
    }
}