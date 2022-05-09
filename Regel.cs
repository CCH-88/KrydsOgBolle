using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrydsOgBolle
{
    public class Regel
    {
        int yBraet;
        int xBraet;
        string spillerBrik;
        string[,] kogbBraet;

        //Indsæt de parametre, som er instances og skal være en del af et spil...
        public Regel(Braet braetInput)
        {
            //Indsætter parameteren "Braet etBraet = new Braet();" i Regel
            kogbBraet = braetInput.GetBraet();

            //En spillerBrik....
            //spillerBrik = enSpiller.SeBrik;

            //Ved ikke, om det skal bruges...
            yBraet = kogbBraet.GetLength(0);
            xBraet = kogbBraet.GetLength(1);



        }

        public bool GyldigtTraek(Spiller enSpiller, int y, int x)
        {
            spillerBrik = enSpiller.SeBrik;

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
