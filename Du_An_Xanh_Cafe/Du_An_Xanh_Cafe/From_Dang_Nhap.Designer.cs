namespace Du_An_Xanh_Cafe
{
    partial class From_Dang_Nhap
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
            chkBoxPassWord = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            label1 = new Label();
            btnDangNhap = new Button();
            SuspendLayout();
            // 
            // chkBoxPassWord
            // 
            chkBoxPassWord.Anchor = AnchorStyles.None;
            chkBoxPassWord.AutoSize = true;
            chkBoxPassWord.BackColor = Color.Transparent;
            chkBoxPassWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkBoxPassWord.ForeColor = Color.White;
            chkBoxPassWord.Location = new Point(266, 293);
            chkBoxPassWord.Name = "chkBoxPassWord";
            chkBoxPassWord.Size = new Size(161, 25);
            chkBoxPassWord.TabIndex = 20;
            chkBoxPassWord.Text = "Hiển thị mật khẩu !";
            chkBoxPassWord.UseVisualStyleBackColor = false;
            chkBoxPassWord.CheckedChanged += chkBoxPassWord_CheckedChanged_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(154, 230);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 19;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoEllipsis = true;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(108, 168);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 18;
            label2.Text = "Tên đăng nhập :";
            // 
            // txtPassWord
            // 
            txtPassWord.Anchor = AnchorStyles.None;
            txtPassWord.BackColor = SystemColors.ControlDark;
            txtPassWord.BorderStyle = BorderStyle.FixedSingle;
            txtPassWord.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            txtPassWord.Location = new Point(266, 228);
            txtPassWord.MaxLength = 20;
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(266, 31);
            txtPassWord.TabIndex = 17;
            txtPassWord.MouseDown += txtPassWord_MouseDown_1;
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.None;
            txtUserName.BackColor = SystemColors.ControlDark;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            txtUserName.Location = new Point(266, 166);
            txtUserName.MaxLength = 25;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(266, 31);
            txtUserName.TabIndex = 16;
            txtUserName.MouseDown += txtUserName_MouseDown_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(287, 52);
            label1.Name = "label1";
            label1.Size = new Size(245, 59);
            label1.TabIndex = 15;
            label1.Text = "Đăng nhập";
            // 
            // btnDangNhap
            // 
            btnDangNhap.Anchor = AnchorStyles.None;
            btnDangNhap.BackColor = Color.Gray;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(287, 364);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(181, 43);
            btnDangNhap.TabIndex = 14;
            btnDangNhap.Text = "Đăng Nhập !";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // From_Dang_Nhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imagee_Dang_Nhap1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 511);
            Controls.Add(chkBoxPassWord);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "From_Dang_Nhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += From_Dang_Nhap_Load;
            KeyDown += From_Dang_Nhap_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkBoxPassWord;
        private Label label3;
        private Label label2;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private Label label1;
        private Button btnDangNhap;
    }
}