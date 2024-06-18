using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Grunnleggende_C_
{

    internal class randomHobby

    {

        //public string name; // must have these variables to run ctorf/ctorp

        //public string address;

        //public randomHobby()
        //{

        //}

        //public randomHobby(string name, string address)
        //{
        //    this.name = name;
        //    this.address = address;
        //}


        public void Run4()
        {
            //string[] hobbies = { reading, painting, cycling, gardening, gaming };
            var isRunning = true;

            Random
                random = new Random(); //lager en instanse for å lage tilfeldige tall( RNG ), som vi seinere tilfører til hobbies-arrayet

            while (isRunning == true) ; //random hobby loop med 
            Console.WriteLine("Who would like a new hobby?"); //user input
            string name = Console.ReadLine();

            //type exit to leave

            if (name.ToLower() == "exit")
            {
                //break;
            }

            //int index = random.Next(hobbies.Length);
            //string randomHobby = hobbies[index];




            ////}



        }
    }
}
