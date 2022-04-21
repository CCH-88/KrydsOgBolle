using System;

namespace KrydsOgBolle
{

    /*View repræsentere den nuværende tilstand af modellen. Den henter data vha. af getter og opdatere controlleren - ikke modellen - vha. af setter metoder. Alternativt, så skal controlleren lytte til view-modellen, som så opdatere modellen...*/
    class View
    {
        public static void Main(string[] args)
        {
            /*Brik enBrik = new Brik();

            Braet etBraet = new Braet();
            etBraet.saetBrik(1,1,enBrik.Kryds);
            etBraet.printBraet(); */


            bool Menu = true;

            while (Menu)
            {
                Menu = VisMenu();
            }


        }

        public static bool VisMenu()
        {
            //Console.Clear();
            Console.WriteLine("\nVelkommen til Kryds og Bolle\n");
            Console.WriteLine("Vælg venligst en af de følgende muligheder\n");
            Console.WriteLine("1: Start nyt spil");
            Console.WriteLine("2: Afslut\n");

            switch (Console.ReadLine())
            {

                case "1":

                    Console.Clear();
                    string inputNavn;

                    do
                    {

                        Console.WriteLine("\nIndtast venligst dit navn");

                        inputNavn = Console.ReadLine();

                    }
                    //returns true if null or empty     
                    while (string.IsNullOrEmpty(inputNavn));

                    string inputBrik;
                    do
                    {
                        Console.WriteLine("\nVælg venligst en brik");

                        inputBrik = Console.ReadLine();
                    }

                    while (string.IsNullOrEmpty(inputBrik));

                    Spiller spillerEt = new Spiller(inputNavn, inputBrik);

                    Spiller spillerTo;

                    /*if(string.Equals(spillerEt.Brik, "O", StringComparison.CurrentCultureIgnoreCase))      
                    {      
                      spillerTo = new Spiller ("Hal1000", "X");

                      //Console.Write("\nNavn på spiller to er " + spillerTo.Navn);     
                      //Console.Write(" og  den har brikken: " + spillerTo.Brik/n);      
                    }

                    else if(string.Equals(spillerEt.Brik, "X", StringComparison.CurrentCultureIgnoreCase))      
                    {      
                      spillerTo = new Spiller ("Hal1000", "O");

                      //Console.Write("\nNavn på spiller to er " + spillerTo.Navn);     
                      //Console.Write(" og den har brikken: " + spillerTo.Brik/n);      
                    }*/

                    /*Braet etBraet = new Braet();
                    etBraet.saetBrik(2,2,"O");
                    etBraet.printBraet();*/

                    return true;

                case "2":

                    Console.WriteLine("\nSpillet afslutter....");
                    return false;


                default:

                    Console.WriteLine("\nIkke en gyldig mulighed. Please try again");

                    return true;
            }

        }
    }

}