using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityQuestionAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you? ");
            int age = int.Parse(Console.ReadLine());
            if (age == 25)
            {
                Console.WriteLine("How many iterations do you want to run Khubaib?");
                int iteration = int.Parse(Console.ReadLine());
                for (int i = 0; i < iteration; i++) 
                {
                    Console.WriteLine("You entered " + iteration + "This is the current integer value in loop " + i);
                }
            }
            Console.ReadKey();
        }


    }
}
