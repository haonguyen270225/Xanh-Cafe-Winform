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
            btnDangNhap = new Button();
            label1 = new Label();
            txtUserName = new TextBox();
            txtPassWord = new TextBox();
            SuspendLayout();
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Gray;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Candara", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(251, 384);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(181, 43);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng Nhập !";
            btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(229, 72);
            label1.Name = "label1";
            label1.Size = new Size(245, 59);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ControlDark;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            txtUserName.Location = new Point(208, 190);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(266, 31);
            txtUserName.TabIndex = 2;
            txtUserName.TextChanged += txtUserName_TextChanged;
            txtUserName.MouseDown += txtUserName_MouseDown;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = SystemColors.ControlDark;
            txtPassWord.BorderStyle = BorderStyle.FixedSingle;
            txtPassWord.Font = new Font("Candara", 14.25F, FontStyle.Bold);
            txtPassWord.Location = new Point(208, 252);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(266, 31);
            txtPassWord.TabIndex = 3;
            txtPassWord.TextChanged += txtPassWord_TextChanged;
            txtPassWord.MouseDown += txtPassWord_MouseDown;
            // 
            // From_Dang_Nhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.imagee_Dang_Nhap1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(734, 511);
            Controls.Add(txtPassWord);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(btnDangNhap);
            Name = "From_Dang_Nhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += From_Dang_Nhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangNhap;
        private Label label1;
        private TextBox txtUserName;
        private TextBox txtPassWord;
    }
}