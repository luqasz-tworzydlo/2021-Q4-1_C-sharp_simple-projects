using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_little_tests_EW
{
    class Program
    {
        enum Typ1T2
        {
            // T2 => Zmienne i stałe [1-2]
            Wiosna, Lato, Jesień, Zima
        }
        enum Typ2T2
        {
            // T2 => Zmienne i stałe [2-2]
            Wiosna, Lato, Jesień, Zima
        };
        static int ObliczT8(int a)
        {
            // T8 => Funkcje [1-2]
            return (a + 1) * (a + 2) % (a - 1);
        }
        static int LiczT8(int a)
        {
            // T8 => Funkcje [2-2]
            return a + a * a;
        }
        static int WykonajT9(ref int a)
        {
            // T9 => Przesyłanie argumentów do metody
            return ++a + 3;
        }
        static int fT10(int x)
        {
            // T10 => Metody - algorytmy rekurencyjne i biblioteka metod [1-3]
            if (x > 1) return fT10(x - 1) + 2 * fT10(x - 2);
            else return x;
        }
        static int hT10(int z)
        {
            // T10 => Metody - algorytmy rekurencyjne i biblioteka metod [2-3]
            if (z < 0) return hT10(z + 1) - 2;
            else return 3;
        }
        static int gT10(int a)
        {
            // T10 => Metody - algorytmy rekurencyjne i biblioteka metod [3-3]
            if (a > 0) return -2 * gT10(a - 2) + 2;
            else return -2;
        }
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////

            Console.WriteLine("//////////////////////////////////////////////////////////");

            Console.WriteLine("\nT1 => Wprowadzenie do języka programowania C#\n");

            Console.WriteLine("//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT2 => Zmienne i stałe\n");

            Console.Write(Typ1T2.Wiosna + " + ");
            Console.Write(Typ1T2.Lato + " + ");
            Console.Write(Typ1T2.Jesień + " + ");
            Console.Write(Typ1T2.Zima + "\n");

            Console.Write(Typ2T2.Wiosna + " + ");
            Console.Write(Typ2T2.Lato + " + ");
            Console.Write(Typ2T2.Jesień + " + ");
            Console.Write(Typ2T2.Zima + "\n");

            Console.WriteLine("\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT3 => Instrukcje warunkowe i wyjątki");

            Console.Write("\n(3.1) Poniższy kod programu oblicza wartość zmiennej c: ");
            double a3 = 6, b3 = 3, c3;
            c3 = (b3 != 0) ? a3 / b3 : 0;
            Console.Write(c3);

            Console.Write("\n(3.2) Poniższy kod oblicza wartość zmiennej i: ");
            int i3 = 12, j3 = -5;
            if (i3 < j3) if (i3 % (-j3) == 0) i3 -= 1; else i3 -= 2;
            else if (-j3 > i3 % 2) i3 -= 3; else i3 -= 4;
            Console.Write(i3);

            Console.Write("\n(3.3) Poniższy kod programu oblicza wartość zmiennej c: ");
            int aa3 = 1, bb3 = 2, cc3 = 3;
            if ((aa3 == 1) && (bb3 < 2)) cc3 += 1;
            else cc3 += 2;
            if ((aa3 < 1) || (bb3 == 2)) cc3 += 3;
            else cc3 += 5;
            Console.Write(cc3);

            Console.WriteLine("\n\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT4 => Instrukcje iteracyjne");

            Console.Write("\n(4.1) Poniższy kod programu wypisuje określoną ilość \"małpek\": ");
            int i4 = 3 + 3 * 3, j4 = 2 + 2 * 2;
            while (--i4 > j4++) Console.Write("@");

            Console.Write("\n(4.2) Poniższy kod programu wypisuje obliczoną liczbę: ");
            int ii4 = 1, aa4 = 2, ile4 = 3;
            while (ii4 <= ile4)
            {
                aa4 *= ile4;
                ii4++;
            }
            Console.WriteLine("{0}", aa4);

            Console.Write("(4.3) Poniższy kod programu wypisuje obliczoną liczbę: ");
            int liczz4 = 4, cos4 = 11;
            do
            {
                cos4 -= liczz4;
            } while (--liczz4 > -1);
            Console.WriteLine("{0}", cos4);

            Console.WriteLine("\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT5 => Pozostałe instrukcje sterujące");

            Console.Write("\n(5.1) Poniższy kod programu oblicza wartość zmiennej a: ");

            int a5 = 2 + 3 / 4 % 5;
            switch (a5)
            {
                case 2: a5 *= 3; break;
                default: a5 += 4; goto case 2;
            }
            Console.WriteLine(a5);

            Console.Write("(5.2) Poniższy kod programu oblicza wartość zmiennej a: ");
            int aa5 = 3;
            switch (aa5)
            {
                case 2: aa5 += 1; break;
                case 3: aa5 += 2; goto case 2;
                case 4: aa5 -= 3; break;
            }
            Console.WriteLine(aa5);

            Console.Write("(5.3) Poniższy kod programu wypisze określoną ilość gwiazdek na ekranie: ");
            goto skok5;
            for (double i5 = 1; i5 < 10; i5++)
            {
                Console.Write(" * ");
            }
        skok5:
            Console.Write(" # ");

            Console.Write("\n(5.4) Poniższy kod programu wypisze określoną ilość gwiazdek na ekranie: ");
            for (int ii5 = 1; ii5 <= 10; ii5++)
            {
                if (ii5 % 2 == 1) continue;
                if (ii5 % 5 == 3) break;
                Console.WriteLine("*");
            }

            Console.WriteLine("(5.5) Poniższy kod programu wypisuje tekst według instrukcji: ");
            int wiek = 11;
            if (wiek >= 18);
            Console.WriteLine("zjem pączka ");
            Console.WriteLine("wypiję piwko ");


            Console.WriteLine("\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT6 => Tablice");

            Console.Write("\n-> Poniższy kod programu wypisuje liczbę na ekranie: ");
            int[] tab1t6 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19
            };
            int[] tab2t6 = { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29
            };
            Array.Copy(tab1t6, 2, tab2t6, 3, 4);
            Console.WriteLine(tab2t6[3]);

            Console.WriteLine("\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT7 => Operacje na tablicach\n");

            Console.WriteLine("//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT8 => Funkcje");

            Console.Write("\n(8.1) Poniższy kod programu wypisuje liczbę na ekranie: ");
            Console.WriteLine(ObliczT8(5));

            Console.Write("(8.2) Poniższy kod programu wypisuje liczbę na ekranie: ");
            Console.WriteLine("{0}", LiczT8(LiczT8(2)));

            Console.WriteLine("\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT9 => Przesyłanie argumentów do metody");

            Console.Write("\n-> Poniższy kod programu przyjmuje nową wartość zmiennej a: ");
            int a9 = 1, b9 = WykonajT9(ref a9);
            a9 += b9;
            Console.WriteLine(a9);

            Console.WriteLine("\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT10 => Metody - algorytmy rekurencyjne i biblioteka metod");

            Console.Write("\n(10.1) Poniższy kod programu wypisuje obliczoną wartość na ekranie: ");
            Console.WriteLine(fT10(4));

            Console.Write("(10.2) Poniższy kod programu wypisuje obliczoną wartość poprzez daną definicję funkcji rekurencyjnej: ");
            Console.WriteLine(hT10(hT10(-4) * (-1)));

            Console.Write("(10.3) Poniższy kod programu wypisuje obliczoną wartość poprzez daną definicję funkcji rekurencyjnej: ");
            Console.WriteLine(gT10(5));

            Console.WriteLine("\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT11 => Struktury\n");

            Console.WriteLine("//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT12 => Pliki\n");

            Console.WriteLine("//////////////////////////////////////////////////////////");

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nT13 => Rekurencyjna struktura danych – lista jednokierunkowa\n");

            Console.WriteLine("//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT14 => Binarne drzewo poszukiwań\n");

            Console.WriteLine("//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.ReadKey();
        }
    }
}
