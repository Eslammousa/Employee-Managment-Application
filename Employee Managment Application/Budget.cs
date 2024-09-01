using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Budget
    {

        public string Id { get; set; }
        public double Value { get; set; }


        public void IncreaseBudget(double Amount) =>  Value += Amount;

        

    }
}
