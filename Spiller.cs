namespace KrydsOgBolle
{

    //Model: Håndterer og administrerer data. F.eks. et array som "Braet-klassen".
    public class Spiller
    {

        // privat felt
        string _navn;
        public static string brikTildelt;
        //Brik enBrik = new Brik();

        public Spiller(string navn, string brik)
        {
            //_navn = navn;
            bool brikVaelger = true;

            _navn = Brik.Kryds;

            while (brikVaelger)
            {
                /*if (string.Equals(Brik.Kryds, "X", StringComparison.CurrentCultureIgnoreCase))
                {
                    //Console.WriteLine("I if-løkken kryds");
                    Brik.Kryds;
                    brikVaelger = false;
                }
                else if (string.Equals(Brik.Bolle, "O", StringComparison.CurrentCultureIgnoreCase))
                {
                    //Console.WriteLine("I if-løkken bolle");
                    //brikTildelt = Brik.Bolle;
                    brikVaelger = false;
                }
                else
                {
                    Console.WriteLine("Det var et ugyldigt valg...");
                    brikVaelger = false;
                }*/


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

        public string Brik
        {

            get
            {
                return brikTildelt;
            }

            set
            {
                brikTildelt = value;
            }

        }

    }

}