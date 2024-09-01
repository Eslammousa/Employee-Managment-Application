using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Department
    {   

        private int id;
        private string name;
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }


        override public string ToString()
        {
            return $"1- Id : {Id} \n2- Name : {Name}";
        }
    }
}
