using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace Du_An_Xanh_Cafe.Class
{
    static internal class Xu_Ly_Chuoi
    {
        public static bool CompareString(string str1, string str2) // so sanh phan biet hoa thuong;
        {
            if (string.Compare(str1, str2, false) == 0)
                return true;
            else
                return false;
        }


        public static string DeleteSpase(string str)
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
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]) == true || chars[i] == ' ' || chars[i] < 'a' && chars[i] > 'z' || chars[i] < 'A' && chars[i] > 'Z')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckPassword(string str)
        {
            //str = str.Xu_Ly;
            if (str.Length < 15) return false;
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ') // khong duoc chua khoan trang !;
                    return false;
            }
            return true;
        }
        
        public static bool CheckNumberPhone(string str)
        {
            str = DeleteSpase(str);
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]) == false) return false; // Chuoi Numberphone khong duoc chua ky tu;
            }
            return false;
        }

    }
}
