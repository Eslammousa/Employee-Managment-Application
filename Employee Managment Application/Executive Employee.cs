using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Executive_Employee : Employee
    {
        private double bonus;

        public double Bonus
        {
            get { return bonus; }

            set
            {
                if (value <= 0) throw new Exception();

                bonus = value;
            }
        }

        public void AddBonus(double MoreBonus)
        {
            bonus += MoreBonus ;
        }
        public override double Pay() => base.Pay() + bonus;
        
        public override void print()
        {
            base.print();
            Console.WriteLine($"Bonus : {bonus}");
        }

    }
}
