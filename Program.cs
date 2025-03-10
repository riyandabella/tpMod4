using System;

public class kodePos
{
    public enum kelurahan {Batununggal, Kujangsari, Mengger,
        Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru,
        Maleer, Samoja};

    public static int getKodePos (kelurahan klrhn)
    {
        int[] kodePos = {40266, 40287, 40267, 40256, 40287,
        40286, 40286, 40286, 40272, 40274, 40273};

        return kodePos[(int) klrhn];
    }
}