using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Xanh_Cafe
{
    internal class Class_Employees
    {
        protected string employeeID;
        protected DateTime birthday;
        protected string passWork;
        protected string userName;
        protected string firtNam;
        protected string lastName;
        protected string middleName;
        protected string numberPhone;

        protected Class_Employees(string employeeID, DateTime birthday, string passWork, string userName, string firtNam, string lastName, string middleName, string numberPhone    )
        {
            this.employeeID = employeeID;
            this.birthday = birthday;
            this.passWork = passWork;
            this.userName = userName;
            this.firtNam = firtNam;
            this.lastName = lastName;
            this.middleName = middleName;
            this.numberPhone = numberPhone;
        }

        protected Class_Employees()
        {
            this.employeeID = "";
            this.birthday = DateTime.MaxValue;
            this.passWork = "";
            this.userName = "";
            this.firtNam = "";
            this.lastName = "";
            this.middleName = "";
            this.numberPhone = "";
        }

        protected  string PassWork {get { return passWork;}}
        protected string UserName {get { return userName;}}
        protected string EmployeeID { get { return employeeID; } }
        
        
        

        
    }
}
