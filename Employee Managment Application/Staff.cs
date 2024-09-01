using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Staff
    {

        public void AddMember(List<StaffMember> staffs)
        {
            Console.WriteLine("Add Staff Member  ");
            Console.Write("Enter Id : ");
            var ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Name : ");
            var Name = Console.ReadLine();
            Console.Write("Enter Phone :");
            var Phone = Console.ReadLine();
            Console.Write("Enter Email : ");
            var Email = Console.ReadLine();

            var staff = new StaffMember
            {
                Id = ID,
                Name = Name,
                Phone = Phone,
                Email = Email
            };
            staffs.Add(staff);
            Console.WriteLine("Information has been successfully added !");
        }

        public void deleteMember(List<StaffMember> staffs)
        {
            Console.WriteLine("Delete Staff Member  ");
            Console.WriteLine(" 1- Id \n 2- Name \n 3- Phone \n 4- Email ");

            Console.Write("Enter Number : ");

            int number = int.Parse(Console.ReadLine());

            if(number > 4 || number < 1)
            {
                Console.WriteLine("Invalid Number you can try again ");
                return;
            }
            switch (number)
            {
                case 1:
                    Console.Write("Enter Id : ");
                    int ID = int.Parse(Console.ReadLine());
                    staffs.RemoveAll(x => x.Id == ID);
                    Console.WriteLine("Id has been deleted successfully !");
                    break;
                case 2:
                    Console.Write("Enter Name : ");
                    string Name = Console.ReadLine();
                    staffs.RemoveAll(x => x.Name == Name);
                    Console.WriteLine("Name has been deleted successfully !");
                    break;
                case 3:
                    Console.Write("Enter Phone : ");
                    string Phone = Console.ReadLine();
                    staffs.RemoveAll(x => x.Phone == Phone);
                    Console.WriteLine("Phone has been deleted successfully !");
                    break;
                case 4:
                    Console.Write("Enter Email : ");
                     string Email = Console.ReadLine();
                    staffs.RemoveAll(x => x.Email == Email);
                    Console.WriteLine("Email has been deleted successfully !");
                    break;
                default:
                    Console.WriteLine("Invalid Number you can try again ");
                    break;
            }

        }

        public void EditMember(List<StaffMember> staffs)
        {
            Console.WriteLine("Edit Staff Member  ");
            Console.WriteLine(" 1- Id \n 2- Name \n 3- Phone \n 4- Email ");

            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            if(number > 4 || number < 1)
            {
                Console.WriteLine("invalid Number you can try again ");
                return;
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine(" Edit Id ");

                    Console.Write(" Enter Old Id : ");
                    int OldID = int.Parse(Console.ReadLine());
                    Console.Write("Enter New Id : ");
                    int NewID = int.Parse(Console.ReadLine());
                    var stafff = new StaffMember
                    {
                        Id = NewID
                    };

                    int index = staffs.FindIndex(x => x.Id == OldID);
                    staffs[index] = stafff;
                    Console.WriteLine("Id has been edited successfully !");

                    break;
                case 2:
                    Console.WriteLine(" Edit Name ");
                    Console.Write(" Enter Old Name : ");
                    string OldName = Console.ReadLine();
                    Console.Write("Enter New Name : ");
                    string NewName = Console.ReadLine();
                    var staff = new StaffMember
                    {
                        Name = NewName
                    };
                    int indexx = staffs.FindIndex(x => x.Name == OldName);
                    staffs[indexx] = staff;
                    Console.WriteLine("Name has been edited successfully !");
                    break;

                case 3:
                    Console.WriteLine(" Edit Phone ");
                    Console.Write(" Enter Old Phone : ");
                    string OldPhone = Console.ReadLine();
                    Console.Write("Enter New Phone : ");
                    string NewPhone = Console.ReadLine();
                    var staffss = new StaffMember
                    {
                        Phone = NewPhone
                    };
                    int indexxx = staffs.FindIndex(x => x.Phone == OldPhone);
                    staffs[indexxx] = staffss;
                    Console.WriteLine("Phone has been edited successfully !");
                    break;

                case 4:
                    Console.WriteLine(" Edit Email ");
                    Console.Write(" Enter Old Email : ");
                    string OldEmail = Console.ReadLine();
                    Console.Write("Enter New Email : ");
                    string NewEmail = Console.ReadLine();
                    var staffsss = new StaffMember
                    {
                        Email = NewEmail
                    };
                    int indexxxx = staffs.FindIndex(x => x.Email == OldEmail);
                    staffs[indexxxx] = staffsss;
                    Console.WriteLine("Email has been edited successfully !");
                    break;

                default:
                    Console.WriteLine("invalid Number you can try again ");
                    break;
            }
            
          }

        public void SearchMember(List<StaffMember> staffs)
        {
            Console.WriteLine("Search Staff Member  ");
            Console.WriteLine(" 1- Id \n 2- Name \n 3- Phone \n 4- Email ");

            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            if(number > 4 || number < 1)
            {
                Console.WriteLine("invalid Number you can try again ");
                return;
            }
            switch (number)
            {
                case 1:
                    Console.Write("Enter Id : ");
                    int ID = int.Parse(Console.ReadLine());
                    if( staffs.Find(x => x.Id == ID) != null)
                    {
                        Console.WriteLine($" successfully found Id : { ID}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($" Not found Id  ");
                        break;
                    }
                    

                case 2:
                    Console.Write("Enter Name : ");
                    string Name = Console.ReadLine();
                    if (staffs.Find(x => x.Name == Name) != null)
                    {
                        Console.WriteLine($" successfully found Name : {Name}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($" Not found Name ");
                        break;
                    }

                case 3:
                    Console.Write("Enter Phone : ");
                    string Phone = Console.ReadLine();
                    if (staffs.Find(x => x.Phone == Phone) != null)
                    {
                        Console.WriteLine($" successfully found Phone : {Phone}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($" Not found Phone "); ;
                        break;
                    }

                case 4:
                    Console.Write("Enter Email : ");
                    string Email = Console.ReadLine();
                    if (staffs.Find(x => x.Email == Email) != null)
                    {
                        Console.WriteLine($" successfully found Email : {Email}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($" Not found Email  ");
                        break;
                    }
                    

                    default :
                    Console.WriteLine("invalid Number you can try again ");
                    break;
            }
        }

        public int Count(List<StaffMember> staffs)
        {
            return staffs.Count;
        }

        public double CalculatePay(List<StaffMember> staffs)
        {
            return staffs.Sum( x => x.Pay());

        }

        public void Print(List<StaffMember> staffs)
        {
           foreach (var item in staffs)
            {
                Console.WriteLine(item);
            }
        }



    }
}
