using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Xanh_Cafe.Class
{
    internal class Class_Acount
    {
        protected string passWord;
        protected  string userName;

        protected internal string PassWork { get { return passWord; } }
        protected internal string UserName { get { return userName; } }

        protected internal Class_Acount()
        {
            this.passWord = "";
            this.userName = "";
        }

        protected internal Class_Acount( string userName , string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }

        protected internal static bool  Check_Acount(Class_Acount a , Class_Acount b)
        {
            if (Xu_Ly_Chuoi.CompareString(a.passWord , b.passWord) && Xu_Ly_Chuoi.CompareString(a.userName , b.userName))
            {
                return true;
            }
            return false;
        }

        protected internal Class_Acount class_Acount()
        {
            return this;
        }


    }
}
