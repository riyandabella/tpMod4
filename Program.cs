using System;
using static DoorMachine;

//public class kodePos
//{
//    public enum Kelurahan
//    {
//        Batununggal, Kujangsari, Mengger,
//        Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru,
//        Maleer, Samoja
//    };

//    public static int getKodePos(Kelurahan kelurahan)
//    {
//        int[] kodePos = {40266, 40287, 40267, 40256, 40287,
//        40286, 40286, 40286, 40272, 40274, 40273};

//        return kodePos[(int)kelurahan];
//    }
//}

public class DoorMachine
{
    public enum state {terkunci, terbuka};

    private state keadaanSekarang;

    public DoorMachine()
    {
        keadaanSekarang = state.terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (keadaanSekarang == state.terkunci)
        {
            keadaanSekarang = state.terbuka;
            Console.WriteLine("Buka Pintu");
        }
        else
        {
            Console.WriteLine("Buka Pintu");
        }
    }

    public void KunciPintu()
    {
        if (keadaanSekarang == state.terbuka)
        {
            keadaanSekarang = state.terkunci;
            Console.WriteLine("Kunci Pintu");
        }
        else
        {
            Console.WriteLine("Kunci Pintu");
        }
    }
}

class main
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();

        Console.WriteLine("buka atau kunci pintu?");
        string perintah = Console.ReadLine();

        if (perintah == "buka")
        {
            pintu.BukaPintu();
        } else if (perintah == "kunci")
        {
            pintu.KunciPintu();
        } else
        {
            Console.WriteLine("masukan 'buka' atau 'kunci'");
        }
    }
}