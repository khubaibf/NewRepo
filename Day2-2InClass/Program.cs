using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_2InClass
{
    class Program
    {
        static void Main(string[] args)
        {
     
            {

                try
                {
                    Console.WriteLine("Please Enter the days you need leave for:");
                    int Leave = int.Parse(Console.ReadLine());

                    if (Leave <= 7 )
                    {
                        Console.WriteLine("You can go on leave:");
                    }
                    else
                    {
                        Console.WriteLine("You can not go on leave:");
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

}
    

