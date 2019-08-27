using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkLibrary { 

    namespace CourseWork
    {
        class Program
            {
            static void Main(string[] args){

                string num = "0";
                int i;

                do
                {
                    Console.WriteLine("CourseWork Testing Menu");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("1 - Unit Test Category");
                    Console.WriteLine("2 - Unit Test Assigment");
                    Console.WriteLine("3 - Exit");
                    Console.Write("Enter Choice: ");
                    num = Console.ReadLine();
                    Console.WriteLine("");

                    if (!Int32.TryParse(num, out i))
                    {

                    }
                    
                    if(i == 1)
                    {
                        Console.WriteLine("**********************");
                        Console.WriteLine("Unit Testing: Category");
                        Console.WriteLine("**********************");
                        Console.WriteLine("Category Name Property: ");
                        Console.WriteLine("Category Percentage Property: ");
                        Console.WriteLine("");
                    }

                    if (i == 2)
                    {
                        Console.WriteLine("**********************");
                        Console.WriteLine("Unit Testing: Assigment");
                        Console.WriteLine("**********************");
                        Console.WriteLine("Assigment Name Property: ");
                        Console.WriteLine("Assigment Description Property: ");
                        Console.WriteLine("Assigment CategoryName Property: ");
                        Console.WriteLine("");
                    }

                    if(i < 1 || i > 3)
                    {
                        Console.WriteLine("Invaild Input");
                        Console.WriteLine("Enter 1, 2 or 3");
                        Console.WriteLine("");
                    }

                } while (i != 3);

                if (i == 3)
                {
                    System.Environment.Exit(1);
                }





            }
        }
    }
}
