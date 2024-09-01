using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Volunteer : StaffMember
    {
        private double amount;

        public double Amount
        {
            get { return amount; }

            set
            {
                if (amount != null && amount >= 0) amount = value;
                else throw new Exception();
            }
        }

        public override void print()
        {
            base.print();
            Console.WriteLine($"Amount : {this.amount}");
        }
        public override double Pay() => amount;
        
    }
}
