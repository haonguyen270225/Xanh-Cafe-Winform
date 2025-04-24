using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Xanh_Cafe.Class
{
    internal class Class_Employees
    {
        protected string employeeID;
        protected DateTime birthday;
        //protected string passWork;
        //protected string userName;
        protected string firtName;
        protected string lastName;
        protected string middleName;
        protected string numberPhone;
        protected string positionID;
        protected Class_Acount acount;

        //protected internal string PassWork { get { return passWork; } }
        //protected internal string UserName { get { return userName; } }
        protected internal Class_Acount Acount {get{return acount;} }
        protected internal string EmployeeID { get { return employeeID; } }
        protected internal string NumberPhone { get { return numberPhone; } }
        protected internal string PositionID { get { return positionID; } }

        protected internal DateTime Birthday { get { return birthday; } }

        protected internal string FirtName {  get { return firtName; } }
        protected internal string LastName {  get { return lastName; } }
        protected internal string MiddleName {  get { return middleName; } }

        protected internal  Class_Employees(string employeeID, DateTime birthday,Class_Acount acount, string firtName, string lastName, string middleName, string numberPhone , string position  )
        {
            this.employeeID = employeeID;
            this.birthday = birthday;
            //this.passWork = passWork;
            //this.userName = userName;
            this.acount = acount;
            this.firtName = firtName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.numberPhone = numberPhone;
            positionID = position;
        }

        protected internal Class_Employees()
        {
            employeeID = "";
            birthday = DateTime.MaxValue;
            //passWork = "";
            //userName = "";
            this.acount = new Class_Acount();
            firtName = "";
            lastName = "";
            middleName = "";
            numberPhone = "";
        }


    }
}
