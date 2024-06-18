using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunnleggende_C_
{
     internal class cLoops
    {

        public void Loops()
        {
            // where we want to put everything in. 
            Run6();
            Run7(); // all loops work with the use of another Method, by calling the statement prior to the function
            Run8();

            void Run6()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Terje Er Kul");
                }
            }

            void Run7()
            {
                // Definerer en streng

                string tekst = "Hei, verden!";

                // Bruker foreach-løkke for å gå gjennom hver bokstav i strengen
                foreach (char bokstav in tekst)
                {
                    Console.WriteLine(bokstav);
                }
            }

            void Run8()
            {
                // Initialiserer rundetelleren
                int rundeteller = 1;

                // While-løkke som kjører så lenge rundetelleren er mindre enn 10
                while (rundeteller < 10)
                {
                    // Printer ut rundetallet
                    Console.WriteLine("Runde nummer: " + rundeteller);

                    // Øker rundetelleren med 1
                    rundeteller++;
                }
            }
        }
        
    }
}
