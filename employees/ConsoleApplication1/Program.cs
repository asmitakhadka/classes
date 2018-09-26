using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the employee's first name: ");
            string fname = Console.ReadLine();
            Console.Write("Please enter the employee's last name: ");
            string lname = Console.ReadLine();
            Console.Write($"Please enter {fname}'s tax rate: ");
            double tax = double.Parse(Console.ReadLine());
            Console.Write($"Please enter {fname}'s Gross annual income: ");
            double gross = double.Parse(Console.ReadLine());

            Employee p1 = new Employee(fname, lname, tax, gross);

            
            Console.WriteLine($"Name: {p1.Fname} {p1.Lname}\nTax: {p1.Tax}%\nGross Salary: {p1.Gross}\nNet Salary: {p1.Net()}");
        }
    }

    class Employee
    {
        
        public string Fname { get; set; }
        public string Lname { get; set; }
        public double Tax { get; set; }
        public double Gross { get; set; }


        
        public Employee(string _fname, string _lname, double _tax, double _gross)
        {
            Fname = _fname;
            Lname = _lname;
            Tax = _tax;
            Gross = _gross;
        }


        public double Net()
        {
            return Gross * (1 - Tax / 100);
        }
    }
}
