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
            // T8 => Funkcje [1-4]
            return (a + 1) * (a + 2) % (a - 1);
        }
        static int LiczT8(int a)
        {
            // T8 => Funkcje [2-4]
            return a + a * a;
        }
        static int m_T8_1(int b, int a)
        {
            // T8 => Funkcje [3-4]
            return b - 2 * a + 1;
        }
        static int m_T8_2(int b, int a)
        {
            // T8 => Funkcje [4-4]
            return b - 2 * a + 1;
        }
        static int WykonajT9(ref int a)
        {
            // T9 => Przesyłanie argumentów do metody
            return ++a + 3;
        }
        static int fT10(int x)
        {
            // T10 => Metody - algorytmy rekurencyjne i biblioteka metod [1-5]
            if (x > 1) return fT10(x - 1) + 2 * fT10(x - 2);
            else return x;
        }
        static int hT10(int z)
        {
            // T10 => Metody - algorytmy rekurencyjne i biblioteka metod [2-5]
            if (z < 0) return hT10(z + 1) - 2;
            else return 3;
        }
        static int gT10(int a)
        {
            // T10 => Metody - algorytmy rekurencyjne i biblioteka metod [3-5]
            if (a > 0) return -2 * gT10(a - 2) + 2;
            else return -2;
        }
        static int ghT10_1(int a)
        {
            // T10 => Metody - algorytmy rekurencyjne i biblioteka metod [4-5]
            if (a <= 0) return -a;

            else return ghT10_1(a - 2) + 3;
        }
        static int ghT10_2(int a)
        {
            // T10 => Metody - algorytmy rekurencyjne i biblioteka metod [5-5]
            if (a <= 0) return -a;

            else return ghT10_2(a - 2) + 3;
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

            Console.Write("\n(3.4) Poniższy kod programu oblicza wartość zmiennej x: ");
            int x3 = 8 % 13 + 16 % 7 + 11 / 14 + 13 / 6;
            Console.WriteLine(x3);
            Console.Write("\t\t\t[!!!] T1 [!!!]");

            Console.Write("\n(3.5) Poniższy kod programu oblicza wartość zmiennej x: ");
            int ii3, xx3 = -1;
            for (ii3 = 7; ii3 < 10; ii3++)
                xx3 += 3;
            Console.WriteLine(xx3);
            Console.Write("\t\t\t[!!!] T5 [!!!]");

            Console.Write("\n(3.6) Poniższy kod programu oblicza wartość zmiennej x: ");
            int xxx3 = 12, yyy3 = 2;
            xxx3 += (xxx3 / yyy3 > 9) ? -yyy3 : -9 + yyy3 % 2;
            Console.WriteLine(xxx3);
            Console.Write("\t\t\t[!!!] T6 [!!!]");

            Console.Write("\n(3.7) Poniższy kod programu oblicza wartość zmiennej x: ");
            int xxxx3 = 18, yyyy3 = 2;
            xxxx3 += (xxxx3 / yyyy3 > 12) ? -yyyy3 : -9 + yyyy3 % 2;
            Console.WriteLine(xxxx3);
            Console.Write("\t\t\t[!!!] T8 [!!!]");

            Console.Write("\n(3.8) Poniższy kod programu oblicza wartość zmiennej x: ");
            int iiiii5, xxxxx3 = -2;
            for (iiiii5 = 8; iiiii5 < 12; iiiii5++)
                xxxxx3 += 3;
            Console.WriteLine(xxxxx3);
            Console.Write("\t\t\t[!!!] T9 [!!!]");

            Console.Write("\n(3.9) Poniższy kod programu oblicza wartość zmiennej x: ");
            int exx3 = 20;
            if (++exx3 < 6) exx3 += 13;
            else exx3 -= 13;
            Console.WriteLine(exx3);
            Console.Write("\t\t\t[!!!] T11 [!!!]");

            Console.Write("\n(3.10) Poniższy kod programu oblicza wartość zmiennej x: ");
            int exxx3 = 5;
            if (++exxx3 < 16) exxx3 += 13;
            else exxx3 -= 13;
            Console.WriteLine(exxx3);
            Console.Write("\t\t\t[!!!] T12 [!!!]");

            Console.Write("\n(3.11) Poniższy kod programu oblicza wartość zmiennej x: ");
            int xX3 = 14 % 5 + 8 % 13 + 17 / 6 + 5 / 12;
            Console.WriteLine(xX3);
            Console.Write("\t\t\t[!!!] T18 [!!!]");

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

            Console.Write("(4.4) Poniższy kod programu wypisuje obliczoną liczbę \"i\": ");
            int iii4 = 14, wynik = -27;
            while (iii4-- > 10)
            {
                if (iii4 % 3 == 0) continue;
                wynik += (iii4 % 3);
            }
            Console.WriteLine(iii4);
            Console.WriteLine("\t\t\t[!!!] T2 [!!!]");

            Console.Write("(4.5) Poniższy kod programu wypisuje obliczoną liczbę \"c\": ");
            int a4 = 12, b4 = 3, c4;
            do
            {
                b4 += (a4++) + 1;
                a4 -= (--b4) - 3;
                if (b4-- > 0) break;
            } while (a4 != b4);
            c4 = a4 + b4;
            Console.WriteLine(c4);
            Console.WriteLine("\t\t\t[!!!] T7 [!!!]");

            Console.Write("(4.6) Poniższy kod programu wypisuje obliczoną liczbę \"c\": ");
            int aaa4 = 10, bbb4 = 11, ccc4;
            do
            {
                bbb4 += (aaa4++) + 1;
                aaa4 -= (--bbb4) - 3;
                if (bbb4-- > 0) break;
            } while (aaa4 != bbb4);
            ccc4 = aaa4 + bbb4;
            Console.WriteLine(ccc4);
            Console.WriteLine("\t\t\t[!!!] T10 [!!!]");

            Console.Write("(4.7) Poniższy kod programu wypisuje obliczoną liczbę \"wynik\": ");
            int iI4 = 13, wynik4 = -25;
            while (iI4-- > 9)
            {
                if (iI4 % 3 == 0) continue;
                wynik4 += (iI4 % 3);
            }
            Console.WriteLine(wynik4);
            Console.WriteLine("\t\t\t[!!!] T17 [!!!]");

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
            if (wiek >= 18) ;
            Console.WriteLine("zjem pączka ");
            Console.WriteLine("wypiję piwko ");

            Console.Write("\n(5.6) Poniższy kod programu oblicza wartość zmiennej a: ");
            int aA5 = 12, bB5 = 7;
            switch (aA5)
            {
                case 11: aA5 = 0; break;
                case 12: aA5 += bB5--; break;
                case 13: aA5++; break;
                default: aA5 -= 3; break;
            }
            Console.WriteLine(aA5);
            Console.Write("\t\t\t[!!!] T13 [!!!]");

            Console.Write("\n(5.7) Poniższy kod programu oblicza wartość zmiennej a: ");
            int aAa5 = 11, bBb5 = 5;
            switch (aAa5)
            {
                case 11: aAa5 += bBb5--; break;
            }
            Console.WriteLine(aAa5);
            Console.WriteLine("\t\t\t[!!!] T14 [!!!]");

            Console.WriteLine("\n//////////////////////////////////////////////////////////");

            //////////////////////////////////////////////////////////

            Console.WriteLine("\nT6 => Tablice");

            Console.Write("\n(6.1) -> Poniższy kod programu wypisuje liczbę na ekranie: ");
            int[] tab1t6 = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19
            };
            int[] tab2t6 = { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29
            };
            Array.Copy(tab1t6, 2, tab2t6, 3, 4);
            Console.WriteLine(tab2t6[3]);

            Console.Write("\n(6.2) -> Poniższy kod programu wypisuje liczbę na ekranie: ");
            int i6, licza6 = 4;
            int[] tabT6 = new int[10] { -2, -3, -1, -2, -3, -1, -1, -3, -4, 0 };
            for (i6 = 2; i6 < 8; ++i6)
                licza6 += tabT6[i6];
            Console.WriteLine(licza6);
            Console.WriteLine("\t\t\t[!!!] T15 [!!!]");

            Console.Write("\n(6.3) -> Poniższy kod programu wypisuje liczbę na ekranie: ");
            int ii6, licze6 = 2;
            int[] tabTt6 = new int[10] { 0, 0, -3, -2, -1, -2, -1, 0, -2, -4 };
            for (ii6 = 2; ii6 < 10; ++ii6)
                licze6 += tabTt6[ii6];
            Console.WriteLine(licze6);
            Console.WriteLine("\t\t\t[!!!] T16 [!!!]");

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

            Console.Write("(8.3) Poniższy kod programu wypisuje obliczoną liczbę na ekranie: ");
            int z8 = m_T8_1(m_T8_1(12, 18), m_T8_1(12, 7));
            Console.WriteLine(z8);
            Console.WriteLine("\t\t\t[!!!] T3 [!!!]");

            Console.Write("(8.4) Poniższy kod programu wypisuje obliczoną liczbę na ekranie: ");
            int zz8 = m_T8_2(m_T8_2(10, 14), m_T8_2(8, 5));
            Console.WriteLine(zz8);
            Console.WriteLine("\t\t\t[!!!] T4 [!!!]");

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

            Console.Write("(10.4) Poniższy kod programu wypisuje obliczoną wartość poprzez daną definicję funkcji rekurencyjnej: ");
            int v = 1 - ghT10_1(12);
            Console.WriteLine(v);
            Console.WriteLine("\t\t\t[!!!] T19 [!!!]");

            Console.Write("(10.5) Poniższy kod programu wypisuje obliczoną wartość poprzez daną definicję funkcji rekurencyjnej: ");
            int vv = 1 - ghT10_2(14);
            Console.WriteLine(vv);
            Console.WriteLine("\t\t\t[!!!] T20 [!!!]");

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
