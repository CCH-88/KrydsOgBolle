namespace KrydsOgBolle;

using System;
using System.Collections.Generic;
using KrydsOgBolle;

//Model: Håndterer og administrerer data. F.eks. et array som "Braet-klassen"
public class Braet
{
    int yLength;
    int xLength;
    string[,] etBraet;

    //Konstruktør som laver et braet. 
    public Braet()
    {
        //Et 2D string-array med 4x4 "[y,x]"...
        etBraet = new string[4, 8]
        {
      { "(Y)"," ","1"," ","2"," ","3"," (X)"},
      { " 1 ","|"," ","|"," ","|"," ","|"},
      { " 2 ","|"," ","|"," ","|"," ","|"},
      { " 3 ","|"," ","|"," ","|"," ","|"},
        };

    }

    public void PrintBraet()
    {
        yLength = etBraet.GetLength(0);
        xLength = etBraet.GetLength(1);

        for (int i = 0; i < yLength; i++)
        {
            for (int j = 0; j < xLength; j++)
            {
                Console.Write(etBraet[i, j]);
            }
            Console.Write(Environment.NewLine);
        }
    }

    public string[,] GetBraet()
    {
        return etBraet;
    }

    public int GetRowLength()
    {
        return etBraet.GetLength(0);

    }

    public int GetColLength()
    {
        return etBraet.GetLength(1);
    }

    public bool SaetBrik(int x, int y, string brik)
    {
        //Maks x-værdi: 7. Gyldige værdier: 1,3,5 og 2,4,6
        if (x == 1 || x == 3 || x == 5 || x == 2 || x == 4 || x == 6)
        {
            //Maks y-værdi: 3. Gyldige værdier: 0,1,2,3.
            if (y == 0 || y == 1 || y == 2 || y == 3)
            {
                etBraet[y, x] = brik;
                return true;
            }

            Console.Write("Y-koordinat er ikke OK...\n");
            return false;
        }

        else
        {
            Console.Write("Ikke en gyldig x-værdi. Prøv venligst igen...\n");
            return false;
        }

    }

}

