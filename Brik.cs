namespace KrydsOgBolle
{

    //Model: Håndterer og administrerer data. F.eks. et array som "Braet-klassen"
    public static class Brik
    {
        // privat felt
        private static string _kryds = "X";

        public static string Kryds
        {
            get
            {
                return _kryds;
            }
        }

        // privat felt
        private static string _bolle = "O";

        public static string Bolle
        {
            get
            {
                return _bolle;
            }
        }

    }

}