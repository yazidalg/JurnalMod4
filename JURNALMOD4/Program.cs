using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Buah
{
    public enum NamaBuah
    {
        Apel, Aprikot, Alpukat, Pisang, Paptika, Blackberry, Ceri,
        Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka
    }

    public static String getKodeBuah(NamaBuah kode)
    {
        String[] kodeBuah = { 
            "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00",
        };

        return kodeBuah[(int)kode];
    }
}

public class PosisiKarakterGame
{
    public enum Trigger
    {
        tombolS, tombolW, tombolX
    }

    public enum Posisi
    {
        Jongkok, Berdiri, Tengkurap, Terbang
    }

    public Posisi initialPosisi = Posisi.Berdiri;

    public void aksi(string command)
    {
        switch (initialPosisi)
        {
            case Posisi.Berdiri:
                if (command == "S")
                {
                    initialPosisi = Posisi.Jongkok;
                    Console.WriteLine("tombol arah bawah ditekan");
                } else if (command == "W")
                {
                    Console.WriteLine("tombol arah atas ditekan");
                    initialPosisi = Posisi.Terbang;
                } else
                {
                    initialPosisi = Posisi.Berdiri;
                }
                break;
            case Posisi.Jongkok:
                if(command == "S")
                {
                    Console.WriteLine("tombol arah bawah ditekan");
                    initialPosisi = Posisi.Tengkurap;
                } else if (command == "W")
                {
                    Console.WriteLine("tombol arah atas ditekan");
                    initialPosisi = Posisi.Berdiri;
                } else
                {
                    initialPosisi = Posisi.Jongkok;
                }
                break;
            case Posisi.Tengkurap:
                if (command == "W")
                {
                    Console.WriteLine("tombol arah bawah ditekan");
                    initialPosisi = Posisi.Jongkok;
                } else
                {
                    initialPosisi = Posisi.Tengkurap;
                }
                break;
            case Posisi.Terbang:
                if (command == "S")
                {
                    Console.WriteLine("tombol arah bawah ditekan");
                    initialPosisi = Posisi.Berdiri;
                }
                else
                {
                    initialPosisi = Posisi.Terbang;
                }
                break;
        }
    }
}

public class MainProgram
{
    public static void Main(String[] args)
    {
        Console.WriteLine(Buah.getKodeBuah(0));
        Console.WriteLine(Buah.NamaBuah.Kurma);
        PosisiKarakterGame posisi = new PosisiKarakterGame();

        string input = Console.ReadLine();
        posisi.aksi(input);
    }
}