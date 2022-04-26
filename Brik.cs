namespace KrydsOgBolle;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KrydsOgBolle;

public class Brik
{
    public Brik()
    {

    }

    // privat felt 
    static string _kryds = "X";

    public static string Kryds
    {
        get
        {
            return _kryds;
        }

        set
        {
            _kryds = value;
        }
    }

    // privat felt 
    static string _bolle = "O";

    public static string Bolle
    {
        get
        {
            return _bolle;
        }

        set
        {
            _bolle = value;
        }
    }
}
