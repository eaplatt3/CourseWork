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
                    Console.WriteLine("1 - Unit Test Catgory");
                    Console.WriteLine("2 - Unit Test Assigment");
                    Console.WriteLine("3 - Exit");
                    Console.Write("Enter Choice: ");
                    num = Console.ReadLine();

                    if (!Int32.TryParse(num, out i))
                    {

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
