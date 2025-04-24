using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Du_An_Xanh_Cafe.Class
{
    internal class Class_Orders
    {
        protected string orderID;
        protected string employeeID;
        protected DateTime dateOrder;
        protected float sumMany;
       
        protected internal string EmployeeID { get { return employeeID; } }

        protected internal string OrderID { get { return orderID;} }

        protected internal DateTime DateOrder { get { return dateOrder; } }

        protected internal float SumMany  { get { return sumMany; } }

        protected internal Class_Orders()
        {
            //new  DateTime(22/4/2005)
            this.orderID = "";
            this.dateOrder = new DateTime(22/4/2025);
            this.employeeID = "";
            this.sumMany = 0;
        }

        protected internal Class_Orders(string orderID, string employeeID, DateTime dateOrder, float sumMany)
        {
            this.orderID = orderID;
            this.employeeID = employeeID;
            this.dateOrder = dateOrder;
            this.sumMany = sumMany;
        }

    }
}
