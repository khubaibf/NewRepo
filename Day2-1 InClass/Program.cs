using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_1_InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Please Enter your Age:");
                int Iage = int.Parse(Console.ReadLine());

                if(Iage > 20)
                {
                    Console.WriteLine("You are old enough to drink:");
                }
                else
                {
                    Console.WriteLine("You are not old enough to drink:");
                }
            }
            catch
            {
                Console.WriteLine("You have an error!");
            }
            Console.ReadKey();
                
                
        }
    }
}
