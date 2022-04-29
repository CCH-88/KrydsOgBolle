namespace KrydsOgBolle;

using System;
using KrydsOgBolle;

//Model: Håndterer og administrerer data. F.eks. et array som "Braet-klassen".
public class Spiller
{

    // privat felt
    string _navn;
    public static string brikTildelt;

    public Spiller(string navn, string brik)
    {
        _navn = navn;
        bool brikVaelger = true;

        while (brikVaelger)
        {
            if (string.Equals(brik, "X", StringComparison.CurrentCultureIgnoreCase))
            {
                //Console.WriteLine("I if-løkken kryds");
                brikTildelt = Brik.Kryds;
                brikVaelger = false;
            }
            else if (string.Equals(brik, "O", StringComparison.CurrentCultureIgnoreCase))
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


    public Spiller LavSpiller(Spiller spillerEt)
    {
        //Find ud af en bedre løsning for den her...
        Spiller? spillerTo = null;

        switch (spillerEt.SeBrik)
        {
            case "O":

                if (string.Equals(spillerEt.SeBrik, "O", StringComparison.CurrentCultureIgnoreCase))
                {
                    spillerTo = new Spiller("Hal 9000", "X");

                    //Console.Write("\nNavn på spiller to er " + spillerTo.Navn);
                    //Console.Write(" og  den har brikken: " + spillerTo.SeBrik + " /n");

                    return spillerTo;
                }
                else
                {
                    return spillerTo;

                }

            case "X":

                if (string.Equals(spillerEt.SeBrik, "X", StringComparison.CurrentCultureIgnoreCase))
                {
                    spillerTo = new Spiller("Hal 9000", "O");

                    //Console.Write("\nNavn på spiller to er " + spillerTo.Navn);
                    //Console.Write(" og den har brikken: " + spillerTo.SeBrik + "/n");

                    return spillerTo;

                }
                else
                {
                    return spillerTo;
                }

            default:
                Console.WriteLine("Ikke en gyldig brik");
                return spillerTo;

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

    public string SeBrik
    {

        get
        {
            brikTildelt = brikTildelt.ToUpper();
            return brikTildelt;
        }

        set
        {
            brikTildelt = brikTildelt.ToUpper();
            brikTildelt = value;
        }

    }

}

