namespace KrydsOgBolle;

/*Controller: Controller er hjernen. Den har ansvaret for, at pulle og modificere data i modellen. Den er forbindelsen mellem modellen og view*/
public class EtSpil
{

    public EtSpil(Spiller spillerEt, Spiller spillerTo, Braet etBraet)
    {

    }

    public bool GyldigtTraek(int x, int y, string brik, Braet etBraet)
    {


        //Mens tur er "True" for den rette spiller, så skal den spiller prøve at sætte en brik 
        while (true)
        {
            if (etBraet.SaetBrik(x, y, brik))
            {

                return true;

            }

        }

        return true;
    }

    public bool Tur { get; set; }


    public bool Afsluttet { get; set; }


    public Braet Tilstand { get; set; }


    //public Brik BrikStatus { get; set; }


}

