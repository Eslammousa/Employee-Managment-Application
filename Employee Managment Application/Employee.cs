using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     abstract class Employee : StaffMember
    {
        private string SSN;

        public string SocialStringNumber
        {
            get
            {
                return SSN;
            }
            set
            {
                if (value.Length >= 0) SSN = value;
                else throw new Exception();
            }
        }


        public override void print()
        {
            base.print();
            Console.WriteLine($"SSN : {this.SSN}");
            

        }
        public override double Pay()
        {
            return base.Pay();
        }


    }
}
