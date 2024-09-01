using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Salaried_Employee : Employee
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0) throw new Exception();

                salary = value;
            } 
        }

        public override double Pay() => salary;
        
        public override void print()
        {
            base.print();
            Console.WriteLine($"Salary : {salary}");
        }
    }
}
