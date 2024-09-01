using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Commission_Employee : Employee
    {
        private int target;

        public int Target
        {
            get { return target; }

            set
            {
                if (value <= 0) throw new Exception();

                target = value;
            }
        }

        public override double Pay() => target * 0.05;


        public override void print()
        {
            base.print();
            Console.WriteLine($"Target : {target * 0.05 }");
        }
    }
}
