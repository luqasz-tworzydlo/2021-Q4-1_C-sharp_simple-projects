using System;

namespace enum_class_static_PP
{
    enum PoraRoku
    {
        // dotyczy => jest to część programu z punktu nr 1.1
        // dotyczy => jest to część programu z punktu nr 1.2

        Wiosna,
        Lato,
        Jesień,
        Zima//,
        //Długość
    }

    enum Miesiąc
    {
        // dotyczy => jest to część programu z punktu nr 2 [1-2]
        Styczeń = 1,
        Luty = 2,
        Marzec = 3,
        Kwiecień = 4,
        Maj = 5,
        Czerwiec = 6,
        Lipiec = 7,
        Sierpień = 8,
        Wrzesień = 9,
        Październik = 10,
        Listopad = 11,
        Grudzień = 12
    }
    enum DzieńTygodnia : sbyte
    {
        // dotyczy => jest to część programu z punktu nr 2 [2-2]
        Niedziela,
        Poniedziałek,
        Wtorek,
        Środa,
        Czwartek,
        Piątek,
        Sobota
    }

    enum MiesiącRzymski
    {
        // dotyczy => jest to część programu z punktu nr 3 [1-5]

        Styczeń = 1,
        Luty = 2,
        Marzec = 3,
        Kwiecień = 4,
        Maj = 5,
        Czerwiec = 6,
        Lipiec = 7,
        Sierpień = 8,
        Wrzesień = 9,
        Październik = 10,
        Listopad = 11,
        Grudzień = 12
    }
    enum MiesiącRzymski2
    {
        // dotyczy => jest to część programu z punktu nr 3 [2-5]

        I = 1,
        II = 2,
        III = 3,
        IV = 4,
        V = 5,
        VI = 6,
        VII = 7,
        VIII = 8,
        IX = 9,
        X = 10,
        XI = 11,
        XII = 12,
    }

    class Program
    {
        static MiesiącRzymski MiesiącRzymskiKonwertuj(string reprezentacjaliczbowa)
        {
            // dotyczy => jest to część programu z punktu nr 3 [3-5]

            /*int numer = Convert.ToInt32(reprezentacjaliczbowa);
            MiesiącRzymski miesiąc = (MiesiącRzymski)miesiąc;
            return miesiąc;*/

            return (MiesiącRzymski)Convert.ToInt32(reprezentacjaliczbowa);
        }
        static MiesiącRzymski PrzesuńMiesiąc(MiesiącRzymski wyjściowy, int przesunięcie)
        {
            // dotyczy => jest to część programu z punktu nr 3 [4-5]

            int przesunięte = (int)(wyjściowy + przesunięcie) % 12;
            if (przesunięte <= 0)
                przesunięte += 12;
            // Miesiąc docelowy = (Miesiąć) przesunięte;
            // return docelowy;
            return (enum_class_static_PP.MiesiącRzymski)przesunięte;
        }
        static void Miesiące()
        {
            // dotyczy => jest to część programu z punktu nr 3 [5-5]

            Console.WriteLine("Podaj numer miesiaca od 1 do 12");
            //int numer = Convert.ToInt32(Console.ReadLine());
            //MiesiącRzymski miesiąc = (MiesiącRzymski)numer;
            MiesiącRzymski miesiąc = MiesiącRzymskiKonwertuj(Console.ReadLine());
            Console.WriteLine("Podałeś miesiąć " + miesiąc);
            /*Console.WriteLine($"10 miesięcy wcześniej był " + PrzesuńMiesiąc(miesiąc, -10));
            Console.WriteLine($"100 miesięcy wcześniej był " + PrzesuńMiesiąc(miesiąc, -100));
            Console.WriteLine($"1000 miesięcy wcześniej był " + PrzesuńMiesiąc(miesiąc, -1000));
            Console.WriteLine($"po 10 miesiącach będzie " + PrzesuńMiesiąc(miesiąc, +10));
            Console.WriteLine($"po 100 miesiącach będzie " + PrzesuńMiesiąc(miesiąc, +100));
            Console.WriteLine($"po 1000 miesiącach będzie " + PrzesuńMiesiąc(miesiąc, +1000));*/
            MiesiącRzymski przesunięty;
            przesunięty = PrzesuńMiesiąc(miesiąc, -10);
            //Console.WriteLine($"10 miesięcy wcześniej był {przesunięty}, to jest miesiąc {MiesiącRzymskiKonwertuj(miesiąc)}");
            Console.WriteLine($"10 miesięcy wcześniej był {przesunięty}, to jest miesiąc {(MiesiącRzymski2)przesunięty}");
            przesunięty = PrzesuńMiesiąc(miesiąc, -100);
            Console.WriteLine($"100 miesięcy wcześniej był {przesunięty}, to jest miesiąc {(MiesiącRzymski2)przesunięty}");
            przesunięty = PrzesuńMiesiąc(miesiąc, -1000);
            Console.WriteLine($"1000 miesięcy wcześniej był {przesunięty}, to jest miesiąc {(MiesiącRzymski2)przesunięty}");
            przesunięty = PrzesuńMiesiąc(miesiąc, +10);
            Console.WriteLine($"po 10 miesięcy będzie {przesunięty}, to jest miesiąc {(MiesiącRzymski2)przesunięty}");
            przesunięty = PrzesuńMiesiąc(miesiąc, +100);
            Console.WriteLine($"po 100 miesięcy będzie {przesunięty}, to jest miesiąc {(MiesiącRzymski2)przesunięty}");
            przesunięty = PrzesuńMiesiąc(miesiąc, +1000);
            Console.WriteLine($"po 1000 miesięcy będzie {przesunięty}, to jest miesiąc {(MiesiącRzymski2)przesunięty}");
        }

        static (int wynik, int reszta) DzielenieCałkowite(int dzielna, int dzielnik)
        {
            // dotyczy => jest to część programu z punktu nr 4

            if (dzielna < 0 && dzielnik < 0)
                return (dzielna / dzielnik, -dzielna % dzielnik);
            else if (dzielna < 0 && dzielnik > 0)
                return (dzielna / dzielnik - 1, dzielna % dzielnik + dzielnik);
            else
                return (dzielna / dzielnik, dzielna % dzielnik);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(";>>>");

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[1.1] Typy wyliczeniowe: wypisanie danej pory roku.\n");

            PoraRoku pora = PoraRoku.Jesień;
            Console.WriteLine("Przyjmujemyt, że pierwsza pora roku to " + (PoraRoku)0);
            Console.WriteLine("Obecna pora roku to " + pora);
            Console.WriteLine($"{pora} to {(int)pora}. roku");
            Console.WriteLine("Następna pora roku to " + (pora + 1));
            Console.WriteLine("Jeszcze następna pora roku to " + (PoraRoku)((int)(pora + 2) % 4));
            //Console.WriteLine("Jeszcze następna pora roku to " + (PoraRoku)((int)(pora + 2) % (int)PoraRoku.Długość));
            //Console.WriteLine("Jak minie " + (PoraRoku)((int)(pora + 2) % 4)  + " to będzie następująca pora roku "+ (PoraRoku)((int)(pora + 3) % 4));

            // program posiada 1 odniesienie do enum - odniesienie do:
            // => enum PoraRoku

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[1.2] Typy wyliczeniowe: wypisanie 4 pór roku.\n");

            // string[] nazwy = Enum.GetNames<PoraRoku>(); // [A - błąd]

            Console.WriteLine("=> Sposób nr 1 na wypisanie wszystkich pór roku");
            string[] nazwy = Enum.GetNames(typeof(PoraRoku)); // [B]
            foreach (string nazwa in nazwy)
                Console.WriteLine(nazwa);

            // [C - błąd]
            // foreach (string nazwa in Enum.GetNames<PoraRoku>())
            //    Console.WriteLine(nazwa);

            Console.WriteLine("\n=> Sposób nr 2 na wypisanie wszystkich pór roku");
            // [D]
            foreach (string nazwa in Enum.GetNames(typeof(PoraRoku)))
                Console.WriteLine(nazwa);

            // program posiada 1 odniesienie do enum - odniesienie do:
            // => enum PoraRoku

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[2] Typy wyliczeniowe: wypisanie wybranego miesiąca (12)," +
                "\njaki jest wybrany dzisiejszy dzień (3) oraz jaki będzie" +
                "\ndzień jutrzejszy po wybranym dniu dzisiejszym.\n");

            Console.WriteLine("Obecnie jest " + (Miesiąc)12);
            Console.WriteLine("Dzisiejszy dzień to " + (DzieńTygodnia)3);
            Console.WriteLine("Jutrzejszy dzień to " + ((DzieńTygodnia)3 + 1));

            // program posiada 2 odniesienia do enum - odniesienie do:
            // => enum Miesiąc
            // => enum DzieńTygodnia : sbyte

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[3] Niniejszy program korzysta z typów wyliczeniowych oraz funkcji:" +
                "\n(3.1) program przyjmuje od użytkownika nazwy lub numery miesiąca" +
                "\n(3.2) program podaje, jakie miesiące były 10, 100 i 1000 miesięcy przed podanym" +
                "\n      oraz podaje, jakie miesiące będą za 10, 100 i 1000 miesięcy po podanym" +
                "\n(3.3) program wypisuje to, co w punkcie (3.2), jednak z zastosowaniem numeru rzymskiego" +
                "\n      (wypisuje miesiąc poprzez jego rzymski numer -> podpowiedź: warto zastosować tutaj," +
                "\n      bądź, przy podobnych operacjach, przykładowo, bliźniaczy typ MiesiącRzymski)\n");

            Miesiące();

            // program posiada 5 odniesień (2 do enum oraz 3 do static) - odniesienie do:
            // => enum MiesiącRzymski
            // => enum MiesiącRzymski2
            // => static MiesiącRzymski MiesiącRzymskiKonwertuj(string reprezentacjaliczbowa)
            // => static MiesiącRzymski PrzesuńMiesiąc(MiesiącRzymski wyjściowy, int przesunięcie)
            // => static void Miesiące()

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[4] Wykonanie operacji dzielenia całkowitego," +
                "\nktóre wyświetla wynik z dzielenia i resztę z dzielenia\n");

            (int wynik, int reszta) dzielenie = DzielenieCałkowite(12, 5);
            Console.WriteLine(
                $"12:5 = {dzielenie.wynik} reszty {dzielenie.reszta}"
                );

            // program posiada 1 odniesienie do enum - odniesienie do:
            // => static (int wynik, int reszta) DzielenieCałkowite(int dzielna, int dzielnik)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            // Warto zapamiętać (na przyszłość):
            // => funkcje (matematyczne w c sharp),
            // => petle (for, while, do...while, foreach + if...else),
            // => podstawowe typy [int, string, char ... double],
            // => tablice dwuwymiarowe (w tym operacje na tablicach),
            // => przykład przeładowania (z zastosowaniem pierwiastka),
            // => typy wyliczeniowe (takie jak: pory roku, miesiące, dni),
            // => operacje na ciągach (tj. rekurencyjna, iteracyjna)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();
        }
    }
}
