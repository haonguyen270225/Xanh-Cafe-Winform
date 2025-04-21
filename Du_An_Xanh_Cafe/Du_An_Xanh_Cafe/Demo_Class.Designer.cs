namespace Du_An_Xanh_Cafe
{
    partial class Demo_Class
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
            txt1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            txt2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(202, 110);
            txt1.Name = "txt1";
            txt1.Size = new Size(257, 27);
            txt1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 113);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(185, 247);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 169);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // txt2
            // 
            txt2.Location = new Point(202, 166);
            txt2.Name = "txt2";
            txt2.Size = new Size(257, 27);
            txt2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(340, 247);
            button2.Name = "button2";
            button2.Size = new Size(119, 29);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(48, 247);
            button3.Name = "button3";
            button3.Size = new Size(119, 29);
            button3.TabIndex = 6;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Demo_Class
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 353);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(txt2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txt1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Demo_Class";
            Text = "Demo_Class";
            Load += Demo_Class_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox txt2;
        private Button button2;
        private Button button3;
    }
}