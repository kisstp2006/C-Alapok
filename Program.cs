using System;

using System.Collections.Generic;

using System.IO;



class Program
{
    int szam = 10;
    double pi = 3.14;
    string nev = "Anna";
    bool igaz = true;

    static void Koszontes()
    {
        Console.WriteLine("Helló, világ!");
    }

    static void Koszontes(string nev)
    {
        Console.WriteLine("Helló, " + nev + "!");
    }

    //Metódus túlterhelés(overloading) ugyan azt a metódus több féle bemeneti értékkel is lehet megadni
    static int Osszeg(int a, int b) { return a + b; }
    static int Osszeg(int a, int b, int c) { return a + b + c; }

    static int Osszeadas(int a, int b)
    {
        return a + b;
    }


    class Auto
    {
        public string marka;
        public int evjarat;
    }

    class Ember
    {
        public string Nev;

        public void Koszontes()
        {
            Console.WriteLine("Szia, " + Nev + "!");
        }
    }
    class Kutya
    {
        public string Nev;
        public int Eletkor;

        public Kutya() { Nev = "Ismeretlen"; Eletkor = 0; }
        public Kutya(string nev) { Nev = nev; Eletkor = 0; }
        public Kutya(string nev, int eletkor) { Nev = nev; Eletkor = eletkor; }
    }

    class Allat
    {
        public void HangotAd() { Console.WriteLine("Az állat hangot ad."); }
    }

    class Kutya2 : Allat
    {
        public void Ugat() { Console.WriteLine("Vau-vau!"); }
    }

    class Allat2
    {
        public virtual void HangotAd() { Console.WriteLine("Az állat hangot ad."); }
    }
    class Macska : Allat2
    {
        public override void HangotAd() { Console.WriteLine("Miau!"); }
    }

    abstract class Allat3
    {
        public abstract void HangotAd();
    }

    class Kutya3 : Allat3
    {
        public override void HangotAd() { Console.WriteLine("Vau-vau!"); }
    }
    interface IAllat
    {
        void HangotAd();
    }

    class Kutya4 : IAllat
    {
        public void HangotAd() { Console.WriteLine("Vau-vau!"); }
    }


    static void Main()
    {

        Console.WriteLine("Hello, World!");

        bool eredmeny = (5 > 3); // true

        bool logikai = (5 > 3) && (10 < 20); // true


        Console.WriteLine("Hello, felhasználó!");


        Console.Write("Add meg a neved: ");
        string nev = Console.ReadLine();
        Console.WriteLine("Szia, " + nev + "!");


        Console.Write("Adj meg egy számot: ");
        int szam = int.Parse(Console.ReadLine());
        Console.WriteLine("A duplája: " + (szam * 2));


        int szam2 = 10;
        if (szam > 5)
        {
            Console.WriteLine("A szám nagyobb mint 5.");
        }
        else
        {
            Console.WriteLine("A szám kisebb vagy egyenlő 5-nél.");
        }

        int nap = 3;
        switch (nap)
        {
            case 1:
                Console.WriteLine("Hétfő");
                break;
            case 2:
                Console.WriteLine("Kedd");
                break;
            case 3:
                Console.WriteLine("Szerda");
                break;
            default:
                Console.WriteLine("Ismeretlen nap");
                break;
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ez a " + (i + 1) + ". ismétlés");
        }

        int szam3 = 0;
        while (szam3 < 5)
        {
            Console.WriteLine(szam3);
            szam3++;
        }
        int szam4 = 0;


        //Végén tesztelő ciklus
        do
        {
            Console.WriteLine(szam4);
            szam4++;
        }
        while (szam4 < 5);

        int[] szamok = { 1, 2, 3, 4, 5 };
        Console.WriteLine(szamok[2]); // Kiírja: 3


        //Tömb bejárása for ciklussal
        for (int i = 0; i < szamok.Length; i++)
        {
            Console.WriteLine(szamok[i]);
        }


        List<string> nevek = new List<string> { "Anna", "Béla", "Cili" };
        nevek.Add("Dénes"); // Új elem hozzáadása
        Console.WriteLine(nevek[1]); // Kiírja: Béla

        foreach (string nev2 in nevek)
        {
            Console.WriteLine(nev2);
        }

        Koszontes();

        Koszontes("Béla");

        Console.WriteLine(Osszeadas(3, 5));


        Console.WriteLine(Osszeg(2, 3)); // 5
        Console.WriteLine(Osszeg(2, 3, 4)); // 9


        Auto auto = new Auto();
        auto.marka = "Ford";
        auto.evjarat = 2020;
        Console.WriteLine(auto.marka + " - " + auto.evjarat);


        Ember ember = new Ember();
        ember.Nev = "Péter";
        ember.Koszontes(); // Kiírja: Szia, Péter!

        Kutya k1 = new Kutya();
        Kutya k2 = new Kutya("Bodri");
        Kutya k3 = new Kutya("Morzsi", 5);

        Console.WriteLine(k3.Nev + " - " + k3.Eletkor + " éves"); // Kiírja: Morzsi - 5 éves

        Kutya2 kutya = new Kutya2();
        kutya.HangotAd(); // Kiírja: Az állat hangot ad.
        kutya.Ugat(); // Kiírja: Vau-vau!

        Macska macska = new Macska();
        macska.HangotAd(); // Kiírja: Miau!


        Kutya3 kutya2 = new Kutya3();
        kutya.HangotAd(); // Kiírja: Vau-vau!

        Kutya4 kutya3 = new Kutya4();
        kutya.HangotAd(); // Kiírja: Vau-vau!


        File.WriteAllText("pelda.txt", "Ez egy teszt fájl.");

        string tartalom = File.ReadAllText("pelda.txt");
        Console.WriteLine(tartalom); // Kiírja: Ez egy teszt fájl.

        string tartalom2 = File.ReadAllText("pelda.txt");
        Console.WriteLine(tartalom); // Kiírja: Ez egy teszt fájl.

        using (StreamWriter sw = new StreamWriter("pelda.txt"))
        {
            sw.WriteLine("Helló világ!");
        }

        using (StreamReader sr = new StreamReader("pelda.txt"))
        {
            Console.WriteLine(sr.ReadToEnd());
        }

        try
        {
            int szam5 = int.Parse("NemSzám");
        }
        catch (FormatException)
        {
            Console.WriteLine("Hibás formátum!");
        }
        //A finally lefut akár van hiba akár nincs

        try
        {
             int szam5 = int.Parse("NemSzám");
        }
        catch (Exception)
        {
            Console.WriteLine("Nullával osztás hiba!");
        }
        finally
        {
            Console.WriteLine("Ez a kód mindig lefut.");
        }



    }

}

// Ez egy egysoros megjegyzés
/* Ez egy
   többsoros megjegyzés */