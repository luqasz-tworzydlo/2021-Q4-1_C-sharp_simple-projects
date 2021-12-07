using System;

namespace recursive_method__PP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(";>>");

            // zaznaczajac tekst oraz naciskajac CTRL + D jest kopiowana linia zaznaczonego kodu na nastepna linie

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[1] Wyświetlanie utworzonej wcześniej listy imion.\n");

            string napis = "Ewa, Adam, Jan, Bożena, Mateusz, Sebastian";

            int ilPrzec = 0;
            for (byte licznik = 0; licznik < napis.Length; licznik++)
                if (napis[licznik] == ',')
                    ilPrzec++;
            string[] imiona = new string[ilPrzec + 1];
            byte indeksWyrazu = 0;
            foreach (char znak in napis)
                if (znak == ' ')
                    continue;
                else if (znak == ',')
                    indeksWyrazu++;
                else
                    imiona[indeksWyrazu] += znak;

            //string[] imionaA = napis.Split(", ");

            //string[] imionaB = napis.Split(", ", StringSplitOptions.None);

            // string[] imiona = napis.Split(new string[] { ", " }, StringSplitOptions.None);

            foreach (string imię in imiona)
                Console.WriteLine(imię);

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[2] Wyświetlanie jakiejś funkcji.\n");

            int y = 0;

            int x = JakaśFunkcja(y);

            Console.WriteLine(x);

            JakaśFunkcja(y);
            Console.WriteLine("Jesteśmy znowu w mainie");
            JakaśFunkcja(y);

            // program posiada 1 odniesienie - odniesienie do:
            // => static int JakaśFunkcja(int y)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[3] Wyświetlanie pierwiastków.\n");

            Console.WriteLine("Pierwiastek z 2 wynosi " + Pierwiastek(2));
            Console.WriteLine("Pierwiastek z 3 wynosi " + Pierwiastek(3));
            Console.WriteLine("Pierwiastek z 4 wynosi " + Pierwiastek(4));

            Console.WriteLine("Pierwiastek sześcienny z 2 wynosi " + Pierwiastek(2, 3));
            Console.WriteLine("Pierwiastek sześcienny z 8 wynosi " + Pierwiastek(8, 3));
            Console.WriteLine("Pierwiastek sześcienny z 20 wynosi " + Pierwiastek(20, 3));

            // program posiada 1 odniesienie - odniesienie do:
            // => static double Pierwiastek(double x, byte stopień = 2)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[4] Wyświetlanie sumy dwóch liczb.\n");

            double a4 = 1, b4 = 2;
            Console.WriteLine($"Suma {a4} + {b4} wynosi {Suma(a4, b4)}");

            // program posiada 1 odniesienie - odniesienie do:
            // => static double Suma(double a, double b)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[5] Wyświetlanie sum różnych liczb z tablicy.\n");

            double a5 = 1, b5 = 2, c5 = 3, d5 = 4;
            Console.WriteLine($"Suma pusta wynosi {SumaSS()}");
            Console.WriteLine($"Suma {a5} wynosi {SumaSS(a5)}");
            Console.WriteLine($"Suma {a5} + {b5} wynosi {SumaSS(a5, b5)}");
            Console.WriteLine($"Suma {a5} + {b5} + {c5} wynosi {SumaSS(a5, b5, c5)}");
            Console.WriteLine($"Suma {a5} + {b5} + {c5} + {d5} wynosi {SumaSS(a5, b5, c5, d5)}");
            double[] tab5 = new double[] { -1, -5, -6, 17, 20 };
            Console.WriteLine("Suma liczb w tablicy wynosi " + SumaSS(tab5));

            // program posiada 1 odniesienie - odniesienie do:
            // => static double SumaSS(params double[] składniki)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[6] Ciąg arytmetyczny i geometryczny: " +
                $"\n=> funkcja przyjmujaca pierwszy wyraz ciągu arytmetycznego," +
                $"\njego roznicę i numer interesujacego nas wyrazu [ zwraca ten wyraz ]" +
                $"\n=> funkcja przyjmujacą pierwszy wyraz ciągu geometrycznego," +
                $"\njego iloraz i numer interesujacego nas wyrazu [ zwraca ten wyraz]\n");

            Console.WriteLine("=> " + Arytmetyczny(10, 5, 20));
            Console.WriteLine("=> " + Arytmetyczny(0.5, 0.25, 21));
            Console.WriteLine("=> " + Geometryczny(1, 2, 10));
            Console.WriteLine("=> " + Geometryczny(32, 0.5, 12));
            Console.WriteLine("=> " + Geometryczny(1, 6, 7));

            // program posiada 2 odniesienia - odniesienie do:
            // => static double Arytmetyczny(double pierwszyWyraz, double różnica, byte indeks)
            // => static double Geometryczny(double pierwszyWyraz, double różnica, byte indeks)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[7] Obliczanie silni dla danych wartości.\n");

            Console.WriteLine("1! = " + SilniaSS(1));
            Console.WriteLine("2! = " + SilniaSS(2));
            Console.WriteLine("3! = " + SilniaSS(3));

            Console.WriteLine("10! = " + SilniaSS(10));
            Console.WriteLine("25! = " + SilniaSS(25));
            
            Console.WriteLine("170! = " + SilniaSS(170));

            // Console.WriteLine("171! = " + SilniaSS(171));
            // powyzsza wartość nie zostanie obliczona ze wzgledu za maly zakres liczb [ wysokosc stosu ]

            // program posiada 1 odniesienie - odniesienie do:
            // => static double SilniaSS(byte n)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[8] Porównanie czasu pracy [ ile zajmuje ]" +
                $"\nrekurencyjnej, iteracyjnej i ogonowej" +
                $"\nwersji funkcji liczącej silnię.\n");

            DateTime startRekk, startOgonowejj, startIterr, stopRekk, stopOgonowejj, stopIterr;

            startRekk = DateTime.Now;
            // for (byte k = 0; k < 10; k++) // pętla for powoduje powtórzenie czynności 10 razy i jest ona opcjonalna
                                          // można ją użyć, aby opóźnić działanie jakiejś funkcji i uwidocznić
                                          // bardziej różnicę, jeśli taka istnieje pomiędzy danymi wersjami
                                          // działać będzie całość róznież bez pętli for [ opóźniającej ]
                SilniaRek(170);
            stopRekk = DateTime.Now;

            startOgonowejj = DateTime.Now;
            // for (byte k = 0; k < 10; k++) // pętla for powoduje powtórzenie czynności 10 razy i jest ona opcjonalna
                SilniaOgonowa(170);
            stopOgonowejj = DateTime.Now;

            startIterr = DateTime.Now;
            // for (byte k = 0; k < 10; k++) // pętla for powoduje powtórzenie czynności 10 razy i jest ona opcjonalna
                SilniaIter(170);
            stopIterr = DateTime.Now;

            Console.WriteLine(
                "=> Rekurencyjna wersja: " + (stopRekk - startRekk)
                );

            Console.WriteLine(
                "=> Ogonowa wersja: " + (stopOgonowejj - startOgonowejj)
                );

            Console.WriteLine(
                "=> Iteracyjna wersja: " + (stopIterr - startIterr)
                );

            // definicja iteracyjna jest najszybsza i warto ją używać

            // jeśli można to rekurencję nalezy unikać
            // definicja rekurencyjna to:
            // 0! = 1
            // n! = (n-1)!

            // program posiada 3 odniesienia - odniesienie do:
            // => static ulong SilniaIter(byte n)
            // => static double SilniaRek(byte n)
            // => static ulong SilniaOgonowa(byte n, ulong wynik = 1)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[9] Porównanie czasu pracy ciągu Fibonacciego" +
                $"\nw wersji rekurencyjnej, iteracyjnej i jawnej.\n");

            ////////////////////////////////////////////////////

            Console.WriteLine("[a] wersja próbna:");

            DateTime startRekTest, stopRekTest, startIterTest, stopIterTest;

            startRekTest = DateTime.Now;
            FibRek(41);
            stopRekTest = DateTime.Now;

            startIterTest = DateTime.Now;
            FibIter(41);
            stopIterTest = DateTime.Now;

            Console.WriteLine("=> Rekurencyjna wersja ciągu (...) [ test ]: " + (stopRekTest - startRekTest));
            Console.WriteLine("=> Iteracyjna wersja ciągu (...) [ test ]: " + (stopIterTest - startIterTest));

            ////////////////////////////////////////////////////

            Console.WriteLine("\n[b] wersja docelowa:");

            DateTime
             startRek,
             stopRek,
             startIter,
             stopIter,
             startJaw,
             stopJaw
             ;

            startRek = DateTime.Now;
            for (byte k = 0; k < 41; k++)
                FibRek(k);
            stopRek = DateTime.Now;

            startIter = DateTime.Now;
            for (byte k = 0; k < 41; k++)
                FibIter(k);
            stopIter = DateTime.Now;

            startJaw = DateTime.Now;
            for (byte k = 0; k < 41; k++)
                FibJawna(k);
            stopJaw = DateTime.Now;

            Console.WriteLine("=> Rekurencyjna wersja ciągu Fibonacciego: " + (stopRek - startRek));
            Console.WriteLine("=> Iteracyjna wersja ciągu Fibonacciego: " + (stopIter - startIter));
            Console.WriteLine("=> Jawna wersja ciągu Fibonacciego: " + (stopJaw - startJaw));

            ////////////////////////////////////////////////////

            // program posiada 3 odniesienia - odniesienie do:
            // => static ulong FibRek(byte n)
            // => static ulong FibIter(byte n)
            // => static double FibJawna(byte n)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            
            Console.ReadKey();
        }

        static int JakaśFunkcja(int y)
        {
            // dotyczy => jest to część programu z punktu nr 2
            int x = 0;
            x += y;
            Console.WriteLine("Jesteśmy w osobnej funkcji");
            Console.WriteLine("X wynosi " + x);
            return x;
        }

        static double Pierwiastek(double x, byte stopień = 2)
        {
            // dotyczy => jest to część programu z punktu nr 3
            // return Math.Sqrt(x);
            if (stopień == 0)
                return double.NaN;
            return Math.Pow(x, 1.0 / stopień);
        }

        static double Suma(double a, double b)
        {
            // dotyczy => jest to część programu z punktu nr 4
            return a + b;
        }

        static double SumaSS(params double[] składniki)
        {
            // dotyczy => jest to część programu z punktu nr 5
            double suma = 0;
            foreach (double składnik in składniki)
                suma += składnik;
            return suma;
        }

        static double Arytmetyczny(double pierwszyWyraz, double różnica, byte indeks)
        {
            // dotyczy => jest to część programu z punktu nr 6 [1-2]
            return pierwszyWyraz + różnica * indeks;
        }
        static double Geometryczny(double pierwszyWyraz, double różnica, byte indeks)
        {
            // dotyczy => jest to część programu z punktu nr 6 [2-2]
            return pierwszyWyraz * Math.Pow(różnica, indeks);
        }

        static double SilniaSS(byte n)
        {
            // dotyczy => jest to część programu z punktu nr 7
            if (n == 0)
                return 1;
            else
                return n * SilniaSS((byte)(n - 1));
        }

        static ulong SilniaIter(byte n)
        {
            // dotyczy => jest to część programu z punktu nr 8 [1-3]
            // silnia iteracyjna to "silnia tradycyjna" (w cudzysłowie)
            ulong wynik = 1;
            while (n > 1)
            {
                wynik *= n;
                n--;
            }
            return wynik;
        }
        static double SilniaRek(byte n)
        {
            // dotyczy => jest to część programu z punktu nr 8 [2-3]
            // silnia rekurencyjna
            if (n == 0)
                return 1;
            else
                return n * SilniaRek((byte)(n - 1));
        }
        static ulong SilniaOgonowa(byte n, ulong wynik = 1)
        {
            // dotyczy => jest to część programu z punktu nr 8 [3-3]
            // silnia ogonowa
            if (n == 0)
                return wynik;
            else
                return SilniaOgonowa((byte)(n - 1), wynik * n);
        }

        static ulong FibRek(byte n)
        {
            // dotyczy => jest to część programu z punktu nr 9 [1-3]
            // ciąg Fibonacciego - wersja rekurencyjna
            if (n < 2)
                return 1;
            else
                return FibRek((byte)(n - 1)) + FibRek((byte)(n - 2));
        }
        static ulong FibIter(byte n)
        {
            // dotyczy => jest to część programu z punktu nr 9 [2-3]
            // ciąg Fibonacciego - wersja iteracyjna
            ulong
                l = 1,
                p = 1
                ;
            for (byte k = 2; k <= n; k++)
            {
                ulong nowy = l + p;
                l = p;
                p = nowy;
            }
            return p;
        }
        static double FibJawna(byte n)
        {
            // dotyczy => jest to część programu z punktu nr 9 [3-3]
            // ciąg Fibonacciego - wersja jawna
            double p5 = Math.Sqrt(5);
            return Math.Pow(0.5 + p5 / 2, n);
        }
    }
}
