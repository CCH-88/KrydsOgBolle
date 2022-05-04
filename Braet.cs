namespace KrydsOgBolle;

using System;
using System.Collections.Generic;
using KrydsOgBolle;

//Model: Håndterer og administrerer data. F.eks. et array som "Braet-klassen"
public class Braet
{
    string[,] etBraet;

    //Konstruktør som laver et braet. 
    public Braet()
    {
        //Et 2D string-array med 4x4 "[y,x]"...
        etBraet = new string[4, 8]
        {
      { "   "," ","1"," ","2"," ","3"," "},
      { " 1 ","|"," ","|"," ","|"," ","|"},
      { " 2 ","|"," ","|"," ","|"," ","|"},
      { " 3 ","|"," ","|"," ","|"," ","|"},
        };

    }

    public void PrintBraet()
    {
        int rowLength = etBraet.GetLength(0);
        int colLength = etBraet.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write(etBraet[i, j]);
            }
            Console.Write(Environment.NewLine);
        }
    }

    public bool SaetBrik(int y, int x, string brik)
    {

        if (y == 2 || y == 4 || y == 6)
        {
            if (x == 2 || x == 4 || x == 6)
            {
                etBraet[y, x] = brik;
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

}

