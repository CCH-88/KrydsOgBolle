namespace KrydsOgBolle;

public class View
{
    public static void Main(string[] args)
    {
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
                while (string.IsNullOrEmpty(inputNavn));

                string inputBrik;

                //returns true (redos the loop) if null or empty 
                do
                {

                    Console.WriteLine("\nVælg venligst en brik, " + inputNavn);
                    inputBrik = Console.ReadLine();

                }
                while (string.IsNullOrEmpty(inputBrik));

                Spiller spillerEt = new Spiller(inputNavn, inputBrik);
                Spiller spillerTo = spillerEt.LavSpiller(spillerEt);

                Console.WriteLine("\nLads os spille! Mit navn er " + spillerTo.Navn + ". Du kan kalde mig Hal, og jeg er blevet tildelt brikken: " + spillerTo.SeBrik);

                bool NytSpil = true;

                while (NytSpil)
                {
                    Console.WriteLine("\nSpillet bliver igangsat....\n");

                    //StartSpil returnerer en bool. Når den returnerer false, så afsluttes while-løkken.
                    NytSpil = StartSpil();
                }

                return true;

            case "2":
                Console.WriteLine("\nSpillet afslutter....");
                return false;

            default:
                Console.WriteLine("\nIkke en gyldig mulighed. Please try again");
                return true;
        }

    }

    public static bool StartSpil()
    {

        Console.WriteLine("\nIndtast venligst en x- og y-værdi\n");

        Braet etBraet = new Braet();
        etBraet.PrintBraet();

        while (true)
        {
            string inputTraek;
            inputTraek = Console.ReadLine();

            if (string.IsNullOrEmpty(inputTraek))
            {
                Console.WriteLine("\nIkke en gyldig x- og y-værdi\n");

                Console.WriteLine("\nIndtast venligst en x- og y-værdi\n");

                return true;
            }
            else if (string.Equals(spillerEt.SeBrik, "O", StringComparison.CurrentCultureIgnoreCase))
            {

            }
        }

        //switch (Console.ReadLine())
        //{
        //    case "0":

        //        return true;
        //    default:
        //        return true;
        //}


    }
}
