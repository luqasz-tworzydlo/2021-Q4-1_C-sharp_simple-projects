using System;

namespace various_methods_PP
{
    class Program
    {
        static int[] Odwróć1(int[] tablica)
        {
            // dotyczy => jest to część programu z punktu nr 1.1

            /*
            1 2 3 4 5 6 7 8 9
            9 2 3 4 5 6 7 8 1
            9 8 3 4 5 6 7 2 1
            9 8 7 4 5 6 3 2 1
            9 8 7 6 5 4 3 2 1
                    !
            9 8 7 6 5 4 3 2 1

            0 1 2 3 4 5 6 7 8 9
            */

            // poniższa instrukcja powoduje odwrócenie wartości w tablicy,
            // czyli zamianę wartości poprzez odwrócenie tablicy i jej wartości
            // [ należy jednak pamiętać, iż instrukcja nie kopiuje wartosci ]

            for (ushort indeks = 0; indeks < tablica.Length / 2; indeks++)
            {
                int temp = tablica[indeks];
                tablica[indeks] = tablica[tablica.Length - 1 - indeks];
                tablica[tablica.Length - 1 - indeks] = temp;
            }
            return tablica;
        }
        static int[] Odwróć2(int[] tablica)
        {
            // dotyczy => jest to część programu z punktu nr 1.2
            
            // poniższa instrukcja powoduje odwrócenie wartości w tablicy
            // [ zamianę wartości poprzez odwrócenie tablicy i jej wartości ]

            // jest to ulepszona wersja programu z punktu 1.1,
            // gdyż nie tylko odwraca wartości, ale również je kopiuje

            int[] kopia = new int[tablica.Length];
            for (ushort indeks = 0; indeks < tablica.Length; indeks++)
                kopia[indeks] = tablica[tablica.Length - 1 - indeks];
            return kopia;
        }

        static bool DzielenieCałkowite(
            int dzielna,
            int dzielnik,
            out int wynik,
            out int reszta
            )
        {
            // dotyczy => jest to część programu z punktu nr 2
            // dotyczy => jest to część programu z punktu nr 6 [2-2]

            if (dzielnik == 0)
            {
                wynik = reszta = 0;
                return false;
            }
            else if (dzielna < 0 && dzielnik < 0)
            {
                wynik = dzielna / dzielnik;
                reszta = -(dzielna % dzielnik);
                return true;
            }
            else if (dzielna < 0 && dzielnik > 0)
            {
                wynik = dzielna / dzielnik - 1;
                reszta = dzielna % dzielnik + dzielnik; ;
                return true;
            }
            else
            {
                wynik = dzielna / dzielnik;
                reszta = dzielna % dzielnik;
                return true;
            }
        }

        static void Podwój1(ref int liczba)
        {
            // dotyczy => jest to część programu z punktu nr 4.1
            liczba *= 2;
        }

        static int Podwój2(int liczba)
        {
            // dotyczy => jest to część programu z punktu nr 4.2 [1-2]
            return liczba * 2;
        }
        static double Podwój3(double liczba)
        {
            // dotyczy => jest to część programu z punktu nr 4.2 [2-2]
            return liczba * 2;
        }

        static double Pierwiastek(ushort stopień, double liczba)
        {
            // dotyczy => jest to część programu z punktu nr 5
            // dotyczy => jest to część programu z punktu nr 6 [1-2]
            if (stopień == 0)
                return double.NaN;
            else if (stopień % 2 == 0 && liczba < 0)
                return double.NaN;
            else
                return Math.Pow(liczba, 1.0 / stopień);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(":>>>");

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[1.1] Odwrócenie argumentów tablicowych oraz ich wyświetlanie.");
            Console.WriteLine("Niniejszy program zawiera błąd, poprawiony w programie [1.2]. ( !!! )\n");

            int[] pierwotna1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] odwrócona1 = Odwróć1(pierwotna1);

            Console.WriteLine("Tablica Pierwotna [ !!! zawiera błąd !!! ] : ");
            foreach (int komórka in pierwotna1)
                Console.WriteLine(komórka + ",\t");

            Console.WriteLine("Tablica Odwrócona: ");
            foreach (int komórka in odwrócona1)
                Console.WriteLine(komórka + ", \t");


            // program posiada 1 odniesienie - odniesienie do:
            // => static int[] Odwróć1(int[] tablica)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[1.2] Odwrócenie argumentów tablicowych oraz ich wyświetlanie.");
            Console.WriteLine("Niniejszy program jest poprawiony i działa, jak powinien. ( !!! )\n");

            int[] pierwotna2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] odwrócona2 = Odwróć2(pierwotna2);

            Console.WriteLine("Tablica Pierwotna: ");
            foreach (int komórka in pierwotna2)
                Console.WriteLine(komórka + ",\t");

            Console.WriteLine("Tablica Odwrócona: ");
            foreach (int komórka in odwrócona2)
                Console.WriteLine(komórka + ", \t");

            // program posiada 1 odniesienie - odniesienie do:
            // => static int[] Odwróć2(int[] tablica)


            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[2] Wykonanie operacji dzielenia całkowitego z wykorzystaniem konkretnych liczb.\n");
            
            int
                dzielna2 = -12,
                dzielnik2 = 5,
                wynik2,
                reszta2
                ;
            
            if (DzielenieCałkowite(dzielna2, dzielnik2, out wynik2, out reszta2))
                Console.WriteLine(
                    $"{dzielna2}:{dzielnik2} = {wynik2} reszty {reszta2}"
                    );
            else
                Console.WriteLine("Nie można dzielić przez 0");

            // program posiada 1 odniesienie - odniesienie do:
            // => static bool DzielenieCałkowite(int dzielna, int dzielnik, out int wynik, out int reszta)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[3] Wykonanie operacji: argumenty outowe.\n");

            string reprezentacja = "12345678901234567890";
            int liczba;
            if (int.TryParse(reprezentacja, out liczba))
                Console.WriteLine(liczba * 2);
            else
                Console.WriteLine("Nie udało się parsowanie " + liczba); // zeruje sie

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[4.1] Funkcja referencyjna: podawanie danych.\n");

            // funkcja referencyjna - nie wymaga podawania recznie danych do referencji
            // referencja - to porzekazanie funkcji informacji o tym gdzie są nasze dane
            // [ f-cja mając te dane będzie wykorzystać dane, które mamy
            // i będzie je odczytywac oraz później zapisywać ]

            int x1 = 2;
            Console.WriteLine(x1);
            Podwój1(ref x1);
            Console.WriteLine(x1);
            Podwój1(ref x1);
            Console.WriteLine(x1);
            Podwój1(ref x1);
            Console.WriteLine(x1);
            Podwój1(ref x1);
            Console.WriteLine(x1);

            // program posiada 1 odniesienie - odniesienie do:
            // => static void Podwój1(ref int liczba)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[4.2] Funkcja referencyjna: podawanie danych.\n");

            Console.WriteLine("[A1] => dotyczy: static int Podwój2(int liczba): ");
            int x2 = 2;
            Console.WriteLine(x2);
            Console.WriteLine(Podwój2(x2));
            Console.WriteLine(Podwój2(x2));
            Console.WriteLine(Podwój2(x2));
            Console.WriteLine(Podwój2(x2));

            Console.WriteLine("\n[A2] => dotyczy: static int Podwój2(int liczba): ");
            short x3 = 2;
            Console.WriteLine(x3);
            Console.WriteLine(Podwój2(x3));
            Console.WriteLine(Podwój2(x3));
            Console.WriteLine(Podwój2(x3));
            Console.WriteLine(Podwój2(x3));

            Console.WriteLine("\n[B1] => dotyczy: static double Podwój3(double liczba): ");
            double x4 = 2.5;
            Console.WriteLine(x4);
            Console.WriteLine(Podwój3(x4));
            Console.WriteLine(Podwój3(x4));
            Console.WriteLine(Podwój3(x4));
            Console.WriteLine(Podwój3(x4));

            // program posiada 2 odniesienia - odniesienie do:
            // => static int Podwój2(int liczba)
            // => static double Podwój3(double liczba)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[5] Przykład przeładowania z użyciem pierwiastka.\n");

            // warto pamiętać o tym, jak wykonać przeładowanie ( !!! )

            Console.WriteLine(
                "Pierwiastek trzeciego stopnia z 2 wynosi " + Pierwiastek(3, 2)
                );
            Console.WriteLine(
                "Pierwiastek trzeciego stopnia z 8 wynosi " + Pierwiastek(3, 8)
                );
            Console.WriteLine(
                "Pierwiastek trzeciego stopnia z 512 wynosi " + Pierwiastek(3, 512)
                );
            Console.WriteLine(
                "Pierwiastek dziewiątego stopnia z 512 wynosi " + Pierwiastek(9, 512)
                );

            // program posiada 1 odniesienie - odniesienie do:
            // => static double Pierwiastek(ushort stopień, double liczba)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n[6] Pzeładowanie z użyciem pierwiastka oraz dzielnie całkowite.\n");

            Console.WriteLine("[A] Przeładowanie z użyciem pierwiastka");
            Console.WriteLine(
                "Pierwiastek 13 stopnia z 3720 wynosi " + Pierwiastek(stopień: 13, liczba: 3720)
                );

            Console.WriteLine("[B] Dzielenie całkowite z użyciem konkretnych liczb");
            int
                w,
                r
                ;
            DzielenieCałkowite(
                wynik: out w,
                reszta: out r,
                dzielna: 12,
                dzielnik: 5
                );
            Console.WriteLine($"12:5 = {w} reszty {r}");

            // program posiada 2 odniesienia - odniesienie do:
            // => static double Pierwiastek(ushort stopień, double liczba)
            // => static bool DzielenieCałkowite(int dzielna, int dzielnik, out int wynik, out int reszta)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.ReadKey();
        }
    }
}
