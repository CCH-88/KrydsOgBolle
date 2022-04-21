using System;

namespace KrydsOgBolle
{

    //Model: Håndterer og administrerer data. F.eks. et array som "Braet-klassen".
    public class Spiller
    {

        // privat felt
        string _navn;
        //string _brikTildelt;
        //Brik enBrik = new Brik();

        public Spiller(string navn, string brik)
        {
            _navn = navn;
            bool brikVaelger = true;

            while (brikVaelger)
            {
                if (string.Equals(brik, "X", StringComparison.CurrentCultureIgnoreCase))
                {
                    //Console.WriteLine("I if-løkken kryds");
                    //Brik.Kryds;
                    brikVaelger = false;
                }
                else if (string.Equals(brik, "O", StringComparison.CurrentCultureIgnoreCase))
                {
                    //Console.WriteLine("I if-løkken bolle");
                    //Brik.Bolle;
                    brikVaelger = false;
                }
                else
                    Console.WriteLine("Det var et ugyldigt valg...");
                brikVaelger = false;

            }

        }


        public string Navn
        {

            get
            {
                return _navn;
            }

            set
            {
                _navn = value;
            }

        }

        /*public string Brik 
        {

          get
          {
            return _brikTildelt;
          }

          set
          {
            _brikTildelt = value;   
          }

        }*/

    }

}