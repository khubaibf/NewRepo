using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            try

            {
                int time = 1;
               
                for (int x = 1; x < 11; x++)
                {
                    Console.WriteLine("your interview time is " + time + " O clock");
                    time++;

                }
                
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}

               
                       
                 

                