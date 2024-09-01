using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Project
    {
        public string id { get; set; }
        public string Location { get; set; }
        public double CurrentCost { get; set; }
       


        public List<Budget> budgets = new List<Budget>();

        public void AddBudget(List<Budget> budgets)
        {
            

            Console.Write("Enter Id : ");
            var ID = Console.ReadLine();
            Console.Write("Enter Value : ");
            var value = double.Parse(Console.ReadLine());

            var bud = new Budget

            {
                Id = ID,
                Value = value,


            }; budgets.Add(bud);

            
        }

        public void getTotalBudget(List<Budget> budgets)
        {
            foreach (var budget in budgets)
            {
                CurrentCost += budget.Value;
            }

        }

        public void Print(List<Budget> budgets)
        {
            Console.WriteLine($"Id_project : {id}");
            Console.WriteLine($"Location : {Location}");
            Console.WriteLine($"Current Cost : {CurrentCost}");
            getTotalBudget(budgets);
            Console.WriteLine($"Total Budget : {CurrentCost}");
  

        }

    }
}
