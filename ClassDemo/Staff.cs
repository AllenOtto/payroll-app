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
            get { return hWorked;  }

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
        // public int HoursWorked { get; set; }

        public int MonthlySalary()
        {
            return hWorked * hourlyRate;
        }
    }
}
