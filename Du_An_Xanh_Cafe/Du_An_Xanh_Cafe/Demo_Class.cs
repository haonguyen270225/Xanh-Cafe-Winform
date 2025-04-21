using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Du_An_Xanh_Cafe
{
    public partial class Demo_Class : Form
    {
        public Demo_Class()
        {
            InitializeComponent();
        }

        private void Demo_Class_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tmp1 = txt1.Text;
            string tmp2 = txt2.Text;
            bool Check = Xu_Lu_Chuoi.CompareString(tmp1, tmp2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = Xu_Lu_Chuoi.DeleteSpase(txt1.Text);
            txt2.Text = Xu_Lu_Chuoi.DeleteSpase(txt2.Text);
            MessageBox.Show("Xoa khoan trang dau va cuoi chuoi !", "Thong bao !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Xu_Lu_Chuoi.CheckUserName(txt1.Text) == false)
            {
                MessageBox.Show("Ten username khong hop le !");
            }
            else if(Xu_Lu_Chuoi.CheckUserName(txt2.Text) == false)
            {
                MessageBox.Show("Ten username khong hop le !");
            }
            else
            {
                MessageBox.Show("Ten hop le !");
            }
        }
    }
}
