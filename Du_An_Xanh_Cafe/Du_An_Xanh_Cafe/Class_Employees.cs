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
        protected string firtName;
        protected string lastName;
        protected string middleName;
        protected string numberPhone;
        protected string positionID;

        protected string PassWork { get { return passWork; } }
        protected string UserName { get { return userName; } }
        protected string EmployeeID { get { return employeeID; } }
        protected string NumberPhone { get { return numberPhone; } }
        protected string PositionID { get { return positionID; } }
        protected Class_Employees(string employeeID, DateTime birthday, string passWork, string userName, string firtNam, string lastName, string middleName, string numberPhone , string position  )
        {
            this.employeeID = employeeID;
            this.birthday = birthday;
            this.passWork = passWork;
            this.userName = userName;
            this.firtName = firtNam;
            this.lastName = lastName;
            this.middleName = middleName;
            this.numberPhone = numberPhone;
            this.positionID = position;
        }

        protected Class_Employees()
        {
            this.employeeID = "";
            this.birthday = DateTime.MaxValue;
            this.passWork = "";
            this.userName = "";
            this.firtName = "";
            this.lastName = "";
            this.middleName = "";
            this.numberPhone = "";
        }
    }
}
