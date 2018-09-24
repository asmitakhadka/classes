using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public int employeeID { get; set; }
        string fname, lname, salary, tax;
        public string fName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string lName
        {
            get { return lname; }
            set { lname = value; }
        }
        public int salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int tax
        {
            get { return tax; }
            set { tax = value; }
        }
        public Employee(string _fname, string _lname, string _salary, string _tax)
        {
            fName = _fname;
            lName = _lname;
            salary = _salary;
            tax = _tax;
        }
        public string NetSalary()
        {
        
        }

    }
    
}
