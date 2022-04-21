namespace KrydsOgBolle
{

    //Model: Håndterer og administrerer data. F.eks. et array som "Braet-klassen"
    public class Brik
    {
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

}