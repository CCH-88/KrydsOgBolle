namespace KrydsOgBolle;

/*Controller: Controller er hjernen. Den har ansvaret for, at pulle og modificere data i modellen. Den er forbindelsen mellem modellen og view*/
public class EtSpil
{

    public EtSpil()
    {

    }

    public bool Tur { get; set; }


    public bool Afsluttet { get; set; }


    public Braet Tilstand { get; set; }


    //public Brik BrikStatus { get; set; }


}

