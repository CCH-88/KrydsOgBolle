﻿namespace KrydsOgBolle;

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
                Console.WriteLine("\nIkke en gyldig mulighed. Prøv venligst igen");
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
        while (string.IsNullOrEmpty(inputNavn) || string.IsNullOrWhiteSpace(inputNavn));


        //returns true (redos the loop) if null, empty or white space
        Console.WriteLine("\nVælg venligst en brik, " + inputNavn);

        bool validBrik = true;

        inputBrik = Console.ReadLine();

        //Prøv at få den til at fungere....
        while (validBrik)
        {

            if (string.Equals(inputBrik, "X", StringComparison.OrdinalIgnoreCase))
            {
                inputBrik = "X";
                validBrik = false;
            }
            else if (string.Equals(inputBrik, "O", StringComparison.OrdinalIgnoreCase))
            {
                inputBrik = "O";
                validBrik = false;
            }
            else if (string.IsNullOrEmpty(inputBrik) || string.IsNullOrWhiteSpace(inputBrik))
            {
                Console.WriteLine("\nPrøv igen, " + inputNavn + ". Den valgte brik skal enten være X (kryds) eller O (bolle)");
                inputBrik = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nPrøv igen, " + inputNavn + ". Den valgte brik skal enten være X (kryds) eller O (bolle)");
                inputBrik = Console.ReadLine();
            }

        }


        //Spillerne laves og spiller to findes ud fra valg af brik af spiller et.
        spillerEt = new Spiller(inputNavn, inputBrik);
        spillerTo = spillerEt.LavSpiller(spillerEt);

        Console.Clear();
        Console.WriteLine("\nLads os spille, " + spillerEt.Navn + ". Mit navn er " + spillerTo.Navn + ". Du kan kalde mig Hal, og jeg er blevet tildelt brikken: " + spillerTo.SeBrik + "\n");

        while (true)
        {
            etBraet.PrintBraet();

            Console.WriteLine("\n" + spillerEt.Navn + ", indtast to tal mellem 1 og 3 separeret med et ',' i rækkefølgen x,y. For eksempel: '3,3'.");

            inputXogY = Console.ReadLine();
            inputMove = inputXogY.Split(',');


            while (!int.TryParse(inputMove[0], out inputX) || !int.TryParse(inputMove[1], out inputY))
            {
                Console.WriteLine("Dette er ikke et gyldigt tal. Indtast et tal mellem 1 og 3. Prøv igen...");

                inputXogY = Console.ReadLine();
                inputMove = inputXogY.Split(',');
            }


            //Tjekker om der er indtastet nogle tal... hvis ja, indsæt parametrene.
            if (!string.IsNullOrEmpty(inputX.ToString()) || !string.IsNullOrEmpty(inputY.ToString()))
            {
                etBraet.SaetBrik(inputX, inputY, spillerEt.SeBrik);
            }
            else
            {
                Console.WriteLine("Den indtastede værdi er ugyldig. Prøv igen...");
            }

        }

    }
}
