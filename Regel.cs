using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrydsOgBolle
{
    internal class Regel
    {
        int yBraet;
        int xBraet;
        string spillerBrik;
        string[,] etBraet;

        //Indsæt de parametre, som er instances og skal være en del af et spil...
        Regel(Spiller enSpiller, Braet braetInput)
        {
            //Næste skridt: Hvorfor virker denne ikke???
            etBraet = braetInput.GetBraet();
            yBraet = braetInput.GetLength(0);
            xBraet = braetInput.GetLength(1);
            spillerBrik = enSpiller.SeBrik;
            //etBraet = new string[laengdeBraet, breddeBraet];

            //GyldigtTraek(4,3);


        }

        public bool GyldigtTraek(int y, int x)
        {

            //Mens tur er "True" for den rette spiller, så skal den spiller prøve at sætte en brik 
            while (true)
            {
                //Tjekker om det er inden for braettet. Erstat med relative variabler, når du har fundet ud af, hvordan klassen skal designes.
                if (y == 2 || y == 4 || y == 6)
                {
                    if (x == 2 || x == 4 || x == 6)
                    {

                        Console.Write("Y og X-koordinat er OK...\n");
                        return true;
                    }

                    Console.Write("Y-koordinat er OK...\n");
                    return true;
                }

                else
                {
                    Console.Write("Ikke et gyldigt træk. Prøv venligst igen...\n");
                    return false;
                }

            }

            return true;
        }
    }
}
