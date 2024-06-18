using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunnleggende_C_
{
    internal class @switch
    {

        int Daynumber = 3;
        public void Run5()
        {
            switch (Daynumber)
            {
                case 1:
                    Console.WriteLine("Mandag");
                    break;
                case 2:
                    Console.WriteLine("Tirsdag");
                    break;
                case 3:
                    Console.WriteLine("Onsdag");
                    break;
                case 4:
                    Console.WriteLine("Torsdag");
                    break;
                case 5:
                    Console.WriteLine("Fredag");
                    break;
                case 6:
                    Console.WriteLine("Lørdag");
                    break;
                case 7:
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Console.WriteLine("Ugyldig dagnummer");
                    break;
            }

        }
    }
}
