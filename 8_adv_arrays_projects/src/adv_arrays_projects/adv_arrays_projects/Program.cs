using System;
using System.Linq;
using System.Numerics;

namespace adv_arrays_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do something! :>");

            byte komenda1;
            do
            {
                Console.WriteLine(
                $"\n\n\n[1] Niniejszy krótki program zapełnia n-elementową tablicę jednowymiarową" +
                $"\nliczb całkowitych wartościami podanymi przez użytkownika [na początku należy" +
                $"\npodać liczbę elementów tablicy, a następnie poszczególne wartości" +
                $"\ndla każdego elementu, który chcemy wyświetlić w programie\n");

                Console.WriteLine("Podaj wartość tworzonej tablicy: ");

                int rozmiar1 = Convert.ToInt32(Console.ReadLine());

                double[] tablica1 = new double[rozmiar1];

                for (int indeks1 = 0; indeks1 < tablica1.Length; indeks1 += 1)
                {
                    double v1;
                    v1 = Convert.ToDouble(Console.ReadLine());
                    tablica1[indeks1] = v1;
                }

                Console.WriteLine(
                    $"\nUżytkownik podał {rozmiar1}-elementową tablicę." +
                    $"\nNiniejsza tablica zawiera poniższe wartości:");

                foreach (double komórka1 in tablica1)
                    Console.WriteLine("=> " + komórka1);

                Console.WriteLine(
                    $"\nWpisz wartość od \"1\" do \"9\" aby wprowadzić nowe dane" +
                    $" i powtórzyć obliczenia \nJeśli chcesz zakończyć program wpisz \"0\"");
                komenda1 = Convert.ToByte(Console.ReadLine());
            } while (komenda1 == 1 || komenda1 == 2 || komenda1 == 3 || komenda1 == 4 || komenda1 == 5 || komenda1 == 6 || komenda1 == 7 || komenda1 == 8 || komenda1 == 9);
            


            Console.WriteLine(
                $"\n\n\n[2] Niniejszy program będzie kopiować liczby całkowite" +
                $"\nz tablicy nr 1 do tablicy nr 2, jednak z zastrzeżeniem," +
                $"\niż mogą zostać wyświetlone wyłącznie liczby dodatnie\n");
            
            Console.WriteLine("Podaj liczby dla tablicy 10-elementowej: ");
            
            int rozmiar2 = 10;
            
            double[] tablicaA1 = new double[rozmiar2];
            
            for (int indeksA1 = 0; indeksA1 < tablicaA1.Length; indeksA1 += 1)
            
            {
                double v2;
                v2 = Convert.ToDouble(Console.ReadLine());
                tablicaA1[indeksA1] = v2;
            }
            
            double[] tablicaA2;
            tablicaA2 = new double[tablicaA1.Length];
            
            for (int indeksA2 = 0; indeksA2 < tablicaA1.Length; indeksA2 += 1)
            {
                tablicaA2[indeksA2] = tablicaA1[indeksA2];
            }
            
            Console.WriteLine(
                $"\nUżytkownik podał wartości dla {rozmiar2}-elementowej tablicy nr 1." +
                $"\nTablica nr 2 [ po usunięciu wartości minusowych ] zawiera:");
            
            foreach (double komórka2 in tablicaA2)
            {
                if(komórka2 >=0)
                {
                    Console.WriteLine("=> " + komórka2);
                }
            }



            Console.WriteLine(
                $"\n\n\n[3] Niniejszy program wyświetli informacje" +
                $"\no n-elementowej tablicy wypełnionej przez użytkownika:" +
                $"\n=> wartość i numer pozycji największego elementu" +
                $"\n=> wartość i numer pozycji najmniejszego elementu" +
                $"\n=> średnia wartości wszystkich elementów tablicy" +
                $"\n=> liczba dodatnich elementów tablicy\n");

            Console.WriteLine("Podaj liczbę wartości dla nowej tablicy");

            int rozmiar3 = Convert.ToInt32(Console.ReadLine());

            double[] tablicaA3 = new double[rozmiar3];

            for (int indeksA3 = 0; indeksA3 < tablicaA3.Length; indeksA3 += 1)

            {
                double v3;
                v3 = Convert.ToDouble(Console.ReadLine());
                tablicaA3[indeksA3] = v3;
            }

            Console.WriteLine(
                $"\nUżytkownik podał wartości dla {rozmiar3}-elementowej tablicy." +
                $"\nStworzona tablica zawiera następujące właściwości:");

            Console.WriteLine("[a]=> Wartość i numer pozycji największego elementu:");
            double max3 = tablicaA3.Length;
            max3 = tablicaA3[0];
            foreach (double komórka3 in tablicaA3)
            {
                if (komórka3 > max3)
                {
                    max3 = komórka3;
                }
            }
            Console.WriteLine("-> " + max3 + " pod indeksem " + Array.IndexOf(tablicaA3, max3));

            Console.WriteLine("[b]=> Wartość i numer pozycji najmniejszego elementu:");
            double min3 = tablicaA3.Length;
            min3 = tablicaA3[0];
            foreach (double komórka3 in tablicaA3)
            {
                if (komórka3 < min3)
                {
                    min3 = komórka3;
                }
            }
            Console.WriteLine("-> " + min3 + " pod indeksem " + Array.IndexOf(tablicaA3, min3));


            Console.WriteLine("[c]=> Średnia wartości wszystkich elementów tablicy:");
            double suma3 = 0;
            foreach (double komórka3 in tablicaA3)
            {
                suma3 += komórka3;
            }
            Console.WriteLine("-> " + suma3 / tablicaA3.Length);

            Console.WriteLine("[d]=> Liczba dodatnich elementów tablicy:");
            foreach (double komórka3 in tablicaA3)
            {
                if (komórka3 >= 0)
                {
                    Console.WriteLine("-> " + komórka3);
                }
            }
            


            Console.WriteLine(
                $"\n\n\n[4.1] Niniejszy program generuje i wyświetla" +
                $"\nliczby pseudolosowe w pętli [ w ilości 100 liczb" +
                $"\nz zakresu 001 - 999 [ gdzie o zakresie decydują" +
                $"\nargumenty podane w wywołaniu metody Next()\n");

            Random randA = new Random();
            for (int i =0; i<100; i++)
                Console.WriteLine("{0,8}", randA.Next(1, 1000));



            Console.WriteLine(
                $"\n\n\n[4.2] Niniejszy program generuje i wyświetla" +
                $"\nliczby pseudolosowe w pętli [ w ilości 100 liczb" +
                $"\nz zakresu liczb int [ gdzie o zakresie decydują" +
                $"\nargumenty podane w wywołaniu metody Next()\n");

            Random randB = new Random();
            for (int i = 0; i < 100; i++)
                Console.WriteLine("{0,8}", randB.Next(-2147483648, 2147483647));

            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
