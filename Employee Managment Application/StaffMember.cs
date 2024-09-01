using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StaffMember
    {
       private int id;
       private string name;
       private string phone;
       private string email;

      public int Id
        {
            get  {  return id;  }
            set
            {
                if (value <= 0 || value.Equals(null))
                {
                    throw new Exception("Negative Value");  
                }
                id = value;
            }
        }
      public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name Must be contain letters");
                  
                }
                name = value;
            }
        }

       public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (value == null || value.Length <= 1) throw new Exception();
                phone = value;
            }
        }

        public string Email { get { return email; }

            set
            {
                if (value == null) throw new Exception("Please Enter your Email");
                email = value;
            }
        }


        public virtual double Pay() => 0.0;
        

       public virtual void print()
        {
            Console.WriteLine($"ID :{this.id}");
            Console.WriteLine($"Name : {this.name}");
            Console.WriteLine($"Phone : {this.phone}");
            Console.WriteLine($"Email : {this.email}");
        }

        





    }
}
