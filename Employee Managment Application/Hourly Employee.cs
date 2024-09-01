using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hourly_Employee : Employee
    {
        private double HW;
        private double rate;

        
        public double HoursWorked
        {
            get { return HW; }

            set
            {
                if (value < 0) throw new Exception();

                HW = value;
            }
        }

        public double Rate
        {
            get { return rate; }
            set
            {
                if (value < 1) throw new Exception();

                rate = value;
            }

        }

        public void AddHours(int MoreHours) => HW += MoreHours;
        

        public override double Pay() => HW * rate;
        


        public override void print()
        {
            base.print();
            Console.WriteLine($"HoursWorked  : {HW}");
            Console.WriteLine($"Rate : {rate}");
            Console.WriteLine($"Pay : {Pay()}");
        }
    }
}
