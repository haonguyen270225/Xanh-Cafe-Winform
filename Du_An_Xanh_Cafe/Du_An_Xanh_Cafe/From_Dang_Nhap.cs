using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_Xanh_Cafe
{
    public partial class From_Dang_Nhap : Form
    {
        public From_Dang_Nhap()
        {
            InitializeComponent();
        }

        private bool flagUserName = true;
        private bool flagPassWord = true;
        private void From_Dang_Nhap_Load(object sender, EventArgs e)
        {
            txtPassWord.Text = "Password...";
            txtUserName.Text = "User name...";
        }

        private void txt_Clar(object sender, MouseEventArgs e)
        {
            if (flagUserName || flagPassWord)
            {
                TextBox a = (TextBox)sender;
                a.Clear();
            }
        }
        private void txtUserName_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Clar(sender, e);
            flagUserName = false;
        }

        private void txtPassWord_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Clar(sender, e);
            flagPassWord = false;
        }
/*        private void txt_Reset(object sender , EventArgs e)
        {
            TextBox a = (TextBox)sender;
            if (a.Text.Length == 0)
            {

            }
        }*/
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length == 0) 
            {
                txtUserName.Text = "User name...";
                txtUserName.SelectAll();
            }
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {
            if(txtPassWord.Text.Length == 0)
            {
                txtPassWord.Text = "PassWord...";
                txtPassWord.SelectAll();
            }
        }
    }
}
