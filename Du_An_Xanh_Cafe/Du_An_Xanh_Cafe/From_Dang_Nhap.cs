using Du_An_Xanh_Cafe.Class;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Du_An_Xanh_Cafe.Class;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Du_An_Xanh_Cafe
{
    public partial class From_Dang_Nhap : Form
    {
        public From_Dang_Nhap()
        {
            InitializeComponent();
        }

        #region BienToanCuc
        Class_Employees nV = new Class_Employees("1121" ,new  DateTime(22/4/2005) , new Class_Acount("userName" , "passWork") ,"Nguyen"  , "Hao" , "Nhat" , "012132313" , "Nhấn Viên");
        private bool flagUserName = true;
        private bool flagPassWord = true; 
        #endregion

        private void From_Dang_Nhap_Load(object sender, EventArgs e)
        {
            this.TopMost = true;   // Form se khong bi de khi dang bat
            chkBoxPassWord.Checked = false;
            txtPassWord.UseSystemPasswordChar = true;
            txtPassWord.Text = "Password...";
            txtUserName.Text = "User name...";
        }

        private void txt_Clar(object sender, MouseEventArgs e)
        {
            TextBox a = (TextBox)sender;
            if ((flagUserName || flagPassWord))
            {
                a.Clear();
            }
        }

        private void chkBoxPassWord_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = !chkBoxPassWord.Checked;
        }

        private void txtUserName_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "User name...")
            {
                txt_Clar(sender, e);
                flagUserName = false;
            }
        }
     
        private void txtPassWord_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (txtPassWord.Text == "Password...")
            {
                txt_Clar(sender, e);
                flagPassWord = false;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //if(Xu_Ly_Chuoi.CompareString(txtPassWord.Text , nV.PassWork) == true && (Xu_Ly_Chuoi.CompareString(txtUserName.Text, nV.UserName) == true)){
            //    MessageBox.Show("Dang nhap thanh cong !" , "Thông báo !" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            //}
            //else if((Xu_Ly_Chuoi.CompareString(txtPassWord.Text, nV.PassWork) == false) && (Xu_Ly_Chuoi.CompareString(txtUserName.Text, nV.UserName) == false))
            //{
            //    MessageBox.Show("Mat khau va ten dang nhap khong dung !" , "Thông báo !" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if(Xu_Ly_Chuoi.CompareString(txtUserName.Text, nV.UserName) == false)
            //{
            //    MessageBox.Show(" Ten dang nhap khong dung !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Mat khau khong dung !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            string passWork = txtPassWord.Text;
            string userName = txtUserName.Text;
            Class_Acount Dang_Nhap = new Class_Acount(passWork , userName);
            if (Class_Acount.Check_Acount(Dang_Nhap, nV.Acount) == true)
            {
                MessageBox.Show("Dang Nhap thanh cong !", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thong tin tai khoan khong dung !", "Thong bao !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
