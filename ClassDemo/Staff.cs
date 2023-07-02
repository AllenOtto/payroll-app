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

        
    }
}
