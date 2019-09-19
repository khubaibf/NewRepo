using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            try

            {
                for (int i = 0; i < 16; i++)
                {
                    Console.WriteLine("How many Pizzas they would like to order?");
                    int Pizza = int.Parse(Console.ReadLine());

                    if (Pizza < 1 || Pizza > 15)
                    {
                        Console.WriteLine("Minimum Pizza per order has to be 1, Max Pizza per order has to be 15");
                    }
                    else
                    {
                        for (int x = Pizza; x >= 1; x--)
                        {
                            Console.WriteLine(Pizza + "Pizza were orderd " +  x +  " More pizza to go");

                        }
                        Console.WriteLine("Order Complete.");
                    }
                    Console.ReadKey();

                }
                }
                catch
            {
                Console.WriteLine("Please enter right number of pizzas");
            }
            }
            
           
        }
    }

