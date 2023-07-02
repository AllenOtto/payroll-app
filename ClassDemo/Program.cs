using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff1 = new Staff("Kelvin");
            staff1.HoursWorked = 160;
            Console.WriteLine(staff1.CalculatePay(1000, 400));

            Staff staff2 = new Staff("Hellen");
            staff2.HoursWorked = 100;
            Console.WriteLine(staff2.CalculatePay());

            Staff staff3 = new Staff("Cindy");
            staff3.HoursWorked = 60;
            Console.WriteLine(staff3.CalculatePay(4500, 500));


            Console.ReadLine();
        }
    }
}
