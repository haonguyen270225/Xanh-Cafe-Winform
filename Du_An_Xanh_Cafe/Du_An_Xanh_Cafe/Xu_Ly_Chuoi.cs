using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Du_An_Xanh_Cafe
{
    static internal class Xu_Ly_Chuoi
    {
       

        public static bool CompareString(string str1 , string str2) // so sanh phan biet hoa thuong;
        {
            if(String.Compare(str1 , str2 ,false) == 0)
                return true;
            else 
                return false;
        }
        

        public static string  DeleteSpase(string str)
        {
            return str.Trim();
        }
       

        public static bool CheckUserName(string str)
        {
            //str = Xu_Lu_Chuoi.DeleteSpase(str);
            char[] chars = str.ToCharArray();
            if (chars.Length > 20)
            {
                return false; // Username qua do dai quy dinh;
            }
            for (int i = 0; i < chars.Length ; i++)
            {
                if ((chars[i] >=  '0' && chars[i] <= '9') || chars[i] == ' ' || (chars[i] < 'a' && chars[i] > 'z') || (chars[i] < 'A' && chars[i] > 'Z') )
                {
                           return false;
                }
            }
            return true;
        }

        public static bool CheckPassword(string str) 
        {
            str = str.Xu_Ly;
            char[] chars = str.ToCharArray();
            
        }
    }
}
