namespace KrydsOgBolle;

public class View
{
    //Spiller spillerEt;
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
        //Braet og regeler objekter laves og initialiseres...      
        Braet etBraet = new Braet();
        Regel kogbRegel = new Regel(etBraet);


        //Spillere objekter laves...
        Spiller spillerEt;
        Spiller spillerTo;

        //inputvariabler til Console.Readline...
        string inputNavn;
        string inputBrik;
        string inputXogY;
        string[] inputMove;
        int inputY;
        int inputX;

        Console.Clear();
        do
        {

            Console.WriteLine("\nIndtast venligst dit navn");
            inputNavn = Console.ReadLine();

        }
        while (string.IsNullOrEmpty(inputNavn));


        //returns true (redos the loop) if null or empty 
        do
        {

            Console.WriteLine("\nVælg venligst en brik, " + inputNavn);
            inputBrik = Console.ReadLine();

        }
        while (string.IsNullOrEmpty(inputBrik));


        //Spillerne laves og spiller to findes ud fra valg af brik af spiller et.
        spillerEt = new Spiller(inputNavn, inputBrik);
        spillerTo = spillerEt.LavSpiller(spillerEt);

        Console.WriteLine("\nLads os spille! Mit navn er " + spillerTo.Navn + ". Du kan kalde mig Hal, og jeg er blevet tildelt brikken: " + spillerTo.SeBrik);

        while (true)
        {
            etBraet.PrintBraet();

            Console.WriteLine("\nIndtast to tal mellem 1 og 3 separeret med et ','. For eksempel: '3,4'.");

            inputXogY = Console.ReadLine();
            inputMove = inputXogY.Split(',');

            try
            {
                inputX = Int32.Parse(inputMove[0]);
                inputY = Int32.Parse(inputMove[1]);

                if (inputX != 0 || inputY != 0)
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Den indtastede værdi er ugyldig. Prøv igen...");
                }


            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);

            }

        }

    }
}
