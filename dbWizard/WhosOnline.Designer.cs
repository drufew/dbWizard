namespace dbWizard
{
    partial class WhosOnline
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Users = new System.Windows.Forms.DataGridView();
            this.gb_Users = new System.Windows.Forms.GroupBox();
            this.rtb_ChatHistory = new System.Windows.Forms.RichTextBox();
            this.gb_Chat = new System.Windows.Forms.GroupBox();
            this.txtSendMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSend = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tmr_UpdateChat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).BeginInit();
            this.gb_Users.SuspendLayout();
            this.gb_Chat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Users
            // 
            this.dgv_Users.AllowUserToAddRows = false;
            this.dgv_Users.AllowUserToDeleteRows = false;
            this.dgv_Users.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Users.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Users.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Users.Location = new System.Drawing.Point(6, 16);
            this.dgv_Users.Name = "dgv_Users";
            this.dgv_Users.ReadOnly = true;
            this.dgv_Users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Users.Size = new System.Drawing.Size(243, 436);
            this.dgv_Users.TabIndex = 1;
            this.dgv_Users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Users_CellContentClick);
            this.dgv_Users.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Users_RowHeaderMouseClick);
            // 
            // gb_Users
            // 
            this.gb_Users.BackColor = System.Drawing.Color.Transparent;
            this.gb_Users.Controls.Add(this.dgv_Users);
            this.gb_Users.Location = new System.Drawing.Point(13, 70);
            this.gb_Users.Name = "gb_Users";
            this.gb_Users.Size = new System.Drawing.Size(255, 463);
            this.gb_Users.TabIndex = 2;
            this.gb_Users.TabStop = false;
            // 
            // rtb_ChatHistory
            // 
            this.rtb_ChatHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_ChatHistory.Location = new System.Drawing.Point(6, 19);
            this.rtb_ChatHistory.Name = "rtb_ChatHistory";
            this.rtb_ChatHistory.Size = new System.Drawing.Size(424, 405);
            this.rtb_ChatHistory.TabIndex = 3;
            this.rtb_ChatHistory.Text = "";
            // 
            // gb_Chat
            // 
            this.gb_Chat.BackColor = System.Drawing.Color.Transparent;
            this.gb_Chat.Controls.Add(this.rtb_ChatHistory);
            this.gb_Chat.Location = new System.Drawing.Point(274, 70);
            this.gb_Chat.Name = "gb_Chat";
            this.gb_Chat.Size = new System.Drawing.Size(439, 430);
            this.gb_Chat.TabIndex = 4;
            this.gb_Chat.TabStop = false;
            this.gb_Chat.Text = "Chat History";
            // 
            // txtSendMessage
            // 
            this.txtSendMessage.Depth = 0;
            this.txtSendMessage.Hint = "";
            this.txtSendMessage.Location = new System.Drawing.Point(274, 510);
            this.txtSendMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSendMessage.Name = "txtSendMessage";
            this.txtSendMessage.PasswordChar = '\0';
            this.txtSendMessage.SelectedText = "";
            this.txtSendMessage.SelectionLength = 0;
            this.txtSendMessage.SelectionStart = 0;
            this.txtSendMessage.Size = new System.Drawing.Size(385, 23);
            this.txtSendMessage.TabIndex = 5;
            this.txtSendMessage.UseSystemPasswordChar = false;
            // 
            // btnSend
            // 
            this.btnSend.Depth = 0;
            this.btnSend.Location = new System.Drawing.Point(665, 510);
            this.btnSend.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSend.Name = "btnSend";
            this.btnSend.Primary = true;
            this.btnSend.Size = new System.Drawing.Size(48, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tmr_UpdateChat
            // 
            this.tmr_UpdateChat.Interval = 500;
            this.tmr_UpdateChat.Tick += new System.EventHandler(this.tmr_UpdateChat_Tick);
            // 
            // WhosOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 540);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSendMessage);
            this.Controls.Add(this.gb_Chat);
            this.Controls.Add(this.gb_Users);
            this.MaximizeBox = false;
            this.Name = "WhosOnline";
            this.Sizable = false;
            this.Text = "Who\'s Online?";
            this.Load += new System.EventHandler(this.WhosOnline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Users)).EndInit();
            this.gb_Users.ResumeLayout(false);
            this.gb_Chat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Users;
        private System.Windows.Forms.GroupBox gb_Users;
        private System.Windows.Forms.RichTextBox rtb_ChatHistory;
        private System.Windows.Forms.GroupBox gb_Chat;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSendMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnSend;
        private System.Windows.Forms.Timer tmr_UpdateChat;
    }
}