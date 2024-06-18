using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunnleggende_C_
{
    internal class Offspring
    {
        public void Run3()
        {

        }








        public void Run2() // oppgave 2 
        {
            Console.WriteLine("Input 1");
        int input1 = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("Input 2");
        int input2 = Convert.ToInt32(Console.ReadLine());

            if (input1 == input2)
            {
                int product = input1 * input2;
                Console.WriteLine($"Product: {product}");
            }
            else 
            {
               int sum = input2 + input1;
                Console.WriteLine($"Sum: {sum}");
            
            }



        }




        int number1 = 5;
        int number2 = 1;
        bool isEqual = false;
        public void Run1()
        {
            { //oppgave 1
                if (number1 == number2)
                {
                    isEqual = true;
                    Console.WriteLine("The NUMBERS ARE INDEED EQUAL");
                }
                else
                {
                    isEqual = false;
                    Console.WriteLine("the numbers are not alike");
                }
                if (isEqual)
                {
                    number1++;
                }
                else
                {
                    number2--;
                }




            }
        }
    }
}
