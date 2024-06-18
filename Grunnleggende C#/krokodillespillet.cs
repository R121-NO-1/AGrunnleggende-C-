using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//lage bruker styrt krokodillespill
// styrt med poeng system
// + poeng om riktig svar - poeng om feil svar
// spillet avsluttes om det skrives noe annet enn de tre "=, <, >"


namespace Grunnleggende_C_
{
    internal class kspillet
    {
        Random random = new Random();
        int score = 0;
        bool playing = true;

        public void Krokodille
        {

            while (playing)
        {
            // Generer to tilfeldige tall mellom 1 og 11
            int number1 = random.Next(1, 12); 
            int number2 = random.Next(1, 12);

 
        }
    }
}
