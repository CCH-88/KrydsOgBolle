namespace KrydsOgBolle;

using System;
using KrydsOgBolle;

//Model: Håndterer og administrerer data. F.eks. et array som "Braet-klassen".
public class Spiller
{

    // privat felt
    string _navn;
    public string brikTildelt;

    public Spiller(string navn, string brik)
    {
        _navn = navn;
        bool brikVaelger = true;

        while (brikVaelger)
        {
            if (string.Equals(Brik.Kryds, "X", StringComparison.CurrentCultureIgnoreCase))
            {
                //Console.WriteLine("I if-løkken kryds");
                brikTildelt = Brik.Kryds;
                brikVaelger = false;
            }
            else if (string.Equals(Brik.Bolle, "O", StringComparison.CurrentCultureIgnoreCase))
            {
                //Console.WriteLine("I if-løkken bolle");
                brikTildelt = Brik.Bolle;
                brikVaelger = false;
            }
            else
            {
                Console.WriteLine("Det var et ugyldigt valg...");
                brikVaelger = false;
            }
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
            return brikTildelt;
        }

        set
        {
            brikTildelt = value;
        }

    }*/

}

