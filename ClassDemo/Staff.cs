using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    internal class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;

        public int HoursWorked
        {
            get { return hWorked; }

            set { 
                if(value > 0)
                {
                    hWorked = value;

                } else
                {
                    hWorked = 0;
                }
            }
        }

        // If you wanted to create getter and setter methods without the if checker, (just a plain getter and setter)
        // The following shortcut option would have sufficed instead of the block of code above
        // public int HoursWorked { get; set; }  // Hii tunaandika pale juu kwa fields. It's just a field/variable 
        // modified to a getter and setter function

        public void PrintMessage()
        {
            Console.WriteLine("Calculating pay...");
        }

        // CalculatePay() Method to calculate staff member pay
        public int CalculatePay()
        {
            PrintMessage();

            if(hourlyRate > 0)
            {
                return hWorked * hourlyRate;
            }
        }

        // Overload the CalculatePay() method with two parameters
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();

            if (hWorked > 0)
            {
                return hWorked * hourlyRate + bonus + allowance;
            }
            else
            {
                return 0;
            }
        }

        // Override the classes pre-defined ToString() method
        public override string ToString()
        {
            return $"Name of Staff = {nameOfStaff}, hourly rate = {hourlyRate}, hours worked = {HoursWorked}";
        }
    }
}
