using System;

namespace arrays_string_type_PP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's use the Polish language once again ''>''");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Tablica nr 1-1 [ pierwszy sposób wyświetlenia tablicy ]");
            Console.WriteLine("");

            int[] tablica;
            tablica = new int[7];
            tablica[0] = 1;
            tablica[1] = 2;
            // tablica[2] = 4;
            // jeśli w danym miejscu jest dziura, czyli brak wartości, domyślnie zostanie to uzupełnione
            // jeśli nie nadamy wartości pod tym indeksem to jest tam domyślna wartość, czyli 0
            tablica[3] = 8;
            tablica[4] = 16;
            tablica[5] = 32;
            tablica[6] = 64;
            // maksymalny indeks to rozmiar-1; jeśli go przekroczyny dostaniemy wyjątek 'index out of range'

            // tablica[7] = 128;
            // nie może być większa ilość wartości, niż zostało to uzgodnione na początku

            //Console.WriteLine(tablica[0]);
            Console.WriteLine(tablica[1]);
            Console.WriteLine(tablica[2]);
            Console.WriteLine(tablica[3]);
            Console.WriteLine(tablica[4]);
            Console.WriteLine(tablica[5]);
            // Console.WriteLine(tablica[6]);  // ^ indeks bierze dany element licząc od końca
            // Console.WriteLine(tablica[^1]); // ^1 to ostatni element [wymagana wersja kompilatora 8.0]
            Console.WriteLine(tablica[tablica.Length - 1]); // poprawiony powyższy fragment kodu [8.0]
            // Console.WriteLine(tablica[^0]); // ^0 to to samo co długość tablicy, więc jest out of range

            Console.WriteLine("");
            Console.WriteLine("Tablica nr 1-2 [ drugi sposób wyświetlenia tablicy ]");
            Console.WriteLine("-> tablica nr 1-2 wykorzystuje\nwartości z tablicy nr 1-1");
            Console.WriteLine("");

            for (uint indeks = 0; indeks < tablica.Length; indeks += 1)
                Console.WriteLine(
                    $"pod indeksem {indeks} jest wartość {tablica[indeks]}"
                    );

            Console.WriteLine("");
            Console.WriteLine("Tablica nr 1-3 [ trzeci sposób wyświetlenia tablicy ]");
            Console.WriteLine("-> tablica nr 1-3 wykorzystuje\nwartości z tablicy nr 1-1\ntak samo jak tablica 1-2");
            Console.WriteLine("");

            foreach (int komórka in tablica)
                Console.WriteLine(
                    komórka
                    );

            // foreach przegląda kolekcję (np. tablicę) od początku do końca; używamy do odczytu

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Tablica nr 2-1 [ automatyczne wypełnianie tablicy, sposób nr A-1 ]");
            Console.WriteLine("-> wypełnienie tablicy kwadratami kolejnych liczb");
            Console.WriteLine("");

            int[] tablicaA1; // może być short[]
            tablicaA1 = new int[30];

            for (ushort indeks = 0; indeks < tablicaA1.Length; indeks++)
                tablicaA1[indeks] = indeks * indeks;

            foreach (int komórkaA1 in tablicaA1)
                Console.WriteLine(komórkaA1);

            Console.WriteLine(
                );

            Console.WriteLine("");
            Console.WriteLine("Tablica nr 2-2 [ automatyczne wypełnianie tablicy, sposób nr A-2 ]");
            Console.WriteLine("-> poniższą tablicę wypełnimy kwadratami kolejnych liczb");
            Console.WriteLine("");


            short[] tablicaA2;
            tablicaA2 = new short[30];

            for (byte indeks = 0; indeks < tablicaA2.Length; indeks++)
                tablicaA2[indeks] = (short)(indeks * indeks); // trzeba zrobić rzutowanie short

            foreach (short komórkaA2 in tablicaA2)
                Console.WriteLine(komórkaA2);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Tablica nr 3-1 [ automatyczne wypełnianie tablicy, sposób nr B-1 ]");
            Console.WriteLine(
                $"-> teraz wypełnimy tablicę w sposób nieco inny," +
                $"\na więc wypełnimy kolejnymi liczbami, które" +
                $"\n zostały pomnożone poprzednio przez liczbę 2" +
                $"\n(do tego można zastosować zmienne liczbowe," +
                $"\ntakie, jak: ulong, long, double, \nfloat, decimal, uint)");
            Console.WriteLine("");

            // Math.Pow(podstawa, wykładnik) <= czasami potrzebne jest rzutowanie np. (uint)Pow.Math(2, indeks)
            // poniższa wersja korzysta z Math.Pow które zwraca double,
            // więc musimy konwertować, gdy tablica jest innego typu
            Console.WriteLine();
            
            uint[] tablicaB1 = new uint [30];
            
            for (byte indeks = 0; indeks < tablicaB1.Length; indeks++)
                tablicaB1[indeks] = (uint) Math.Pow(2, indeks);
            
            foreach (uint komórkaB1 in tablicaB1)
                Console.WriteLine(komórkaB1);

            Console.WriteLine("");
            Console.WriteLine("Tablica nr 3-2 [ automatyczne wypełnianie tablicy, sposób nr B-2 ]");
            Console.WriteLine(
                $"-> wypełniamy tablicę kolejnymi kolejnymi liczbami, które" +
                $"\n zostały pomnożone poprzednio przez liczbę 2 (1x2, 2x2," +
                $"\n4x2, 8x2, [...], 64x2, [...] do momenu osiągnięcia 30 liczb)" +
                $"\n(użyć co najmniej z uint, ulong, long, double, float, decimal)");
            Console.WriteLine("");

            // Math.Pow(podstawa, wykładnik) <= czasami potrzebne jest rzutowanie np. (uint)Pow.Math(2, indeks)
            // wykorzystać dodatkowo: tablica[0] = 1 oraz tablican[n] = 2 * tablica[n - 1]
            // poniższa wersja zaczyna z zadaną wartością początkowej komórki
            // kolejne komórki mnożą poprzednie przez dwa [*2]

            uint[] tablicaB2 = new uint[30];
            tablicaB2[0] = 1;

            for (byte indeks = 1; indeks < tablicaB2.Length; indeks++)
                tablicaB2[indeks] = 2 * tablicaB2[indeks - 1];

            foreach (uint komórkaB2 in tablicaB2)
                Console.WriteLine(komórkaB2);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Tablica nr 4 [ konwersja, kopiowanie tablicy ]");
            Console.WriteLine("");

            uint[] tablicaC1 = new uint[10];
            for (byte indeks = 0; indeks < tablicaC1.Length; indeks++)
                tablicaC1[indeks] = (uint)indeks * 3;

            double[] tablicaC2;
            // tablicaC2 = new double[1]; // to tworzy tablice double'ową o zadanym rozmiarze
            // nie wpływa to na fakt, że konwersje niżej nie działają
            // poniższe konwersje są niemożliwe
            // tablicaC2 = tablicaC1;
            // tablicaC2 = (double[])tablicaC1;

            // konwersja wymaga pętli oraz utworzenia nowej tablicy z długością zgodną z długością tej kopiowanej
            tablicaC2 = new double[tablicaC1.Length]; // lepiej używać długości, a nie liczb, aby oszczędzić czas pracy
            for (byte indeks = 0; indeks < tablicaC1.Length; indeks++)
                tablicaC2[indeks] = tablicaC1[indeks];

            foreach (double komórkaC in tablicaC2)
                Console.WriteLine(komórkaC / 2);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Tablica nr 5 [ modyfikacje na tablicy ]");
            Console.WriteLine("");

            int
                aa = 5,
                bb = aa
                ;
            bb += 2;
            Console.WriteLine(
                $"a: {aa}, b: {bb} - wartość pierwotnej zmiennej nie została zmodyfikowana"
                );

            int[]
                A = new int[3],
                B
                ;

            A[0] = 1;
            A[1] = 2;
            A[2] = 3;

            // 1* to nie jest skopiowanie wartości, tylko referencji - B  i A są aliasami,
            // wskazują na tą samą instancję
            // B = A;

            // 2* faktyczna kopia danych wymaga utworzenia nowej tablicy i skopiowania wartosci petli

            B = new int[A.Length];
            for (byte indeks = 0; indeks < A.Length; indeks += 1)
                B[indeks] = A[indeks];

            // 1* modyfikacja wartości w tablicy wskazywanej przez referencję B
            // jest to ta sama tablica co wskazywana przez referencje A
            B[0] += 1;
            B[1] += 2;
            B[2] -= 10;

            Console.WriteLine("A:");
            foreach (int komórka in A)
                Console.WriteLine(
                    $"{komórka} "
                    );

            Console.WriteLine("\n B:");
            foreach (int komórka in B)
                Console.WriteLine(
                    $"{komórka} "
                    );

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Tablica nr 6 [ tworzenie nowej tablicy ]");
            Console.WriteLine("");

            Console.WriteLine("Podaj wartośc tworzonej tablicy: ");

            byte rozmiarR1 = Convert.ToByte(Console.ReadLine());

            double[] tablicaR1 = new double[rozmiarR1];

            for (byte indeks = 0; indeks < tablicaR1.Length; indeks += 1)
                tablicaR1[indeks] = indeks / 3;

            foreach (double komórkaR1 in tablicaR1)
                Console.WriteLine(komórkaR1);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Tablica nr 7-1 [ skrótowy konstruktor tablicy, sposób T-1]");
            Console.WriteLine("");

            int[] tablicaT1 = new int[] { 1, 2, 3, 9, 7, 5, 11, 13, 17 };

            foreach (int komórkaT1 in tablicaT1)
                Console.WriteLine(komórkaT1);

            Console.WriteLine("");
            Console.WriteLine("Tablica nr 7-2 [ skrótowy konstruktor tablicy, sposób T-2]");
            Console.WriteLine("");

            int[] tablicaT2 = new int[] { 1, 2, 3, 9, 7, 5, 11, 13, 17 };

            for (byte indeks = 0; indeks < tablicaT2.Length; indeks++)
                Console.WriteLine(
                    $"{indeks} : {tablicaT2[indeks]}"
                    );

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(
                $"Zarzyj do kodu ;>" +
                $"\n... more in C# code ;p");

            Console.ReadKey();
        }
    }
}
