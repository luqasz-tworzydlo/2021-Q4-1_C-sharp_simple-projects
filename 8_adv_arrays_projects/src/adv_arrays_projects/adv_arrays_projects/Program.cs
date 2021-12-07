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
            
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

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
            
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

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

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

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
            
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[4.1] Niniejszy program generuje i wyświetla" +
                $"\nliczby pseudolosowe w pętli [ w ilości 100 liczb" +
                $"\nz zakresu 001 - 999 [ gdzie o zakresie decydują" +
                $"\nargumenty podane w wywołaniu metody Next()\n");

            Random randA = new Random();
            for (int i =0; i<100; i++)
                Console.WriteLine("{0,8}", randA.Next(1, 1000));

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[4.2] Niniejszy program generuje i wyświetla" +
                $"\nliczby pseudolosowe w pętli [ w ilości 100 liczb" +
                $"\nz zakresu liczb int [ gdzie o zakresie decydują" +
                $"\nargumenty podane w wywołaniu metody Next()\n");

            Random randB = new Random();
            for (int i = 0; i < 100; i++)
                Console.WriteLine("{0,8}", randB.Next(-2147483648, 2147483647));

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////////
            
            Console.WriteLine(
                $"\n\n\n[5] Niniejszy program będzie kopiować liczby całkowite" +
                $"\nz tablicy nr 1 do tablicy nr 2, jednak z przesunięciem," +
                $"\no jedną pozycję w prawo [ dla tablicy n-elementowej ].\n");

            Console.WriteLine("Podaj liczbę wartości dla nowej tablicy");

            int rozmiar5A = Convert.ToInt32(Console.ReadLine());

            double[] tablica5A = new double[rozmiar5A];

            for (int indeks5A = 0; indeks5A < tablica5A.Length; indeks5A += 1)

            {
                double v5;
                v5 = Convert.ToDouble(Console.ReadLine());
                tablica5A[indeks5A] = v5;
            }

            double[] tablica5B;
            tablica5B = new double[tablica5A.Length];

            for (int indeks5B = 0; indeks5B < rozmiar5A-1; indeks5B += 1)
            {
                tablica5B[indeks5B] = tablica5A[indeks5B+1];
            }
            tablica5B[rozmiar5A - 1] = tablica5A[0];

            Console.WriteLine(
                $"\nUżytkownik podał wartości dla {rozmiar5A}-elementowej tablicy nr 1." +
                $"\nTablica nr 2 [ po przesunięciu o jedną pozycję w prawo ] zawiera:");

            Console.WriteLine();

            foreach (double komórka5 in tablica5B)
            {
                Console.WriteLine("=> " + komórka5 + " z indeksem " + Array.IndexOf(tablica5B, komórka5));
            }

            ///////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[6] Niniejszy program deklaruje oraz inicjalizuje" +
                $"\ndwuwymiarową tablicę liczb rzeczywistych o rozmiarze 5 x 2." +
                $"\nProgram wyświetla elementy tablicy oraz sumę jej elementów.\n");

            int[,] tablica2d = new int[,] {
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
                { 4, 4 },
                { 5, 5 } };

            for (int axa = 0; axa < tablica2d.GetLength(0); axa++)
            {
                for (int bix = 0; bix < tablica2d.GetLength(1); bix++)
                {
                    Console.WriteLine("{0,3} ", tablica2d[axa, bix]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("");

            // program posiada 2 odniesienia - odniesienie do:
            // => static int sumaElementów(int[,] tablica2d)
            // => static int sumaElementówPrzekątna(int[,] tablica2d)

            Console.WriteLine("Rozmiar [wyświetlenie] tablicy dwuwymiarowej: " + tablica2d.Length);
            Console.WriteLine("Suma wszystkich elementów tablicy dwuwymiarowej: " + sumaElementów(tablica2d));
            Console.WriteLine("Suma wszystkich elementów przekątnej tablicy2d: " + sumaElementówPrzekątna(tablica2d));

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[7] Niniejszy program deklaruje oraz inicjalizuje" +
                $"\ndwuwymiarową tablicę liczb rzeczywistych o rozmiarze 5 x 5." +
                $"\nProgram wyświetla elementy tablicy oraz sumę jej elementów.\n");

            int[,] tablica2d5x5 = new int[,] {
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 } };

            próbatablica2d5x5(tablica2d5x5);
            // program posiada 4 odniesienia - odniesienie do:
            // => static void próbatablica2d5x5(int[,] tablica2d5x5)
            // => static void wyświetltablica2d5x5(int[,] tablica2d5x5)
            // => static int sumaElementów(int[,] tablica2d)
            // => static int sumaElementówPrzekątna(int[,] tablica2d)

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[8] Niniejszy program dodaje dwie macierze o rozmiarze 2 x 3." +
                $"\nProgram wyświetla macierz wynikową. Macierz wynikowa C zawiera elementy," +
                $"\nktóre stanowią sumę elementów macierzy A i B o odpowiednich indeksach," +
                $"\ntzn. element w zerowym wierszu oraz zerowej kolumnie macierzy A" +
                $"\njest dodawany do elementu o tych samych indeksach macierzy B," +
                $"\nelement A[0, 1] do B[0, 1]...itd" +
                $"\nProgram wyświetla nową tablicę, czyli" +
                $"\ntablicę C [zawierającą sumę tablic A i B].\n");

            int[,] tablica2d2x3A = new int[,] {
                { 1, 2, 3 },
                { 1, 2, 3 } };
            int[,] tablica2d2x3B = new int[,] {
                { 1, 2, 3 },
                { 1, 2, 3 } };
            int[,] tablica2d2x3CSUMA = new int[2, 3];

            int ini = 0;
            int jen = 0;
            Array.Copy(tablica2d2x3B, tablica2d2x3CSUMA, 6);
            foreach (int aja in tablica2d2x3A)
            {
                for (; ini < tablica2d2x3CSUMA.GetLength(0);)
                {
                    for (; jen < tablica2d2x3CSUMA.GetLength(1);)
                    {
                        tablica2d2x3CSUMA[ini, jen] += aja;
                        jen++;
                        break;
                    }
                    if (jen == tablica2d2x3CSUMA.GetLength(1))
                    {
                        ini++;
                        jen = 0;
                    }
                    break;
                }
            }

            for (int iie = 0; iie < tablica2d2x3CSUMA.GetLength(0); iie++)
            {
                for (int jee = 0; jee < tablica2d2x3CSUMA.GetLength(1); jee++)
                {
                    Console.Write(tablica2d2x3CSUMA[iie, jee]);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // drugi alternatywny sposób
            // próbatablica2d5x5(tablica2d2x3CSUMA);

            // trzeci sposób alternatywny
            //foreach (int kej in tablica2d2x3CSUMA)
            //{
            //    Console.WriteLine(" {0}", kej);
            //}

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[9] Niniejszy program wyświetla wybrany dzień tygodnia." +
                $"\nw wybranym języku [ polskim, niemieckim, angielskim ]\n");

            string[] dniTygodnia7 = new string[21];
            dniTygodnia7[0] = "Poniedziałek";
            dniTygodnia7[1] = "Wtorek";
            dniTygodnia7[2] = "Środa";
            dniTygodnia7[3] = "Czwartek";
            dniTygodnia7[4] = "Piątek";
            dniTygodnia7[5] = "Sobota";
            dniTygodnia7[6] = "Niedziela";

            dniTygodnia7[7] = "Monday";
            dniTygodnia7[8] = "Tuesday";
            dniTygodnia7[9] = "Wednesday";
            dniTygodnia7[10] = "Thursday";
            dniTygodnia7[11] = "Friday";
            dniTygodnia7[12] = "Saturday";
            dniTygodnia7[13] = "Sunday";

            dniTygodnia7[14] = "Montag";
            dniTygodnia7[15] = "Dienstag";
            dniTygodnia7[16] = "Mittwoch";
            dniTygodnia7[17] = "Donnerstag";
            dniTygodnia7[18] = "Freitag";
            dniTygodnia7[19] = "Samstag";
            dniTygodnia7[20] = "Sonntag";

            byte komenda7;
            do
            {
                int język;
                Console.WriteLine(
                    $"Wybierz jednej z dostępnych języków" +
                    $"\nWpisz \"1\" dla języka polskiego" +
                    $"\nWpisz \"2\" dla języka angielskiego" +
                    $"\nWpisz \"3\" dla języka niemieckiego");
                język = Convert.ToInt32(Console.ReadLine());
                switch (język)
                {
                    case 1:
                        {
                            int dzień7;
                            Console.WriteLine("\"PL\"Który wypisać dzień tygodnia? ");
                            dzień7 = Convert.ToInt32(Console.ReadLine());
                            switch (dzień7)
                            {
                                case 1: Console.WriteLine("=> " + dniTygodnia7[0]); break;
                                case 2: Console.WriteLine("=> " + dniTygodnia7[1]); break;
                                case 3: Console.WriteLine("=> " + dniTygodnia7[2]); break;
                                case 4: Console.WriteLine("=> " + dniTygodnia7[3]); break;
                                case 5: Console.WriteLine("=> " + dniTygodnia7[4]); break;
                                case 6: Console.WriteLine("=> " + dniTygodnia7[5]); break;
                                case 7: Console.WriteLine("=> " + dniTygodnia7[6]); break;
                                default:
                                    Console.WriteLine("Nie ma takiego dnia :<"); break;
                            }
                        }; break;
                    case 2:
                        {
                            int dzień7;
                            Console.WriteLine("\"ENG\"Which day do you want to display? ");
                            dzień7 = Convert.ToInt32(Console.ReadLine());
                            switch (dzień7)
                            {
                                case 1: Console.WriteLine("=> " + dniTygodnia7[7]); break;
                                case 2: Console.WriteLine("=> " + dniTygodnia7[8]); break;
                                case 3: Console.WriteLine("=> " + dniTygodnia7[9]); break;
                                case 4: Console.WriteLine("=> " + dniTygodnia7[10]); break;
                                case 5: Console.WriteLine("=> " + dniTygodnia7[11]); break;
                                case 6: Console.WriteLine("=> " + dniTygodnia7[12]); break;
                                case 7: Console.WriteLine("=> " + dniTygodnia7[13]); break;
                                default:
                                    Console.WriteLine("There is no such day :<"); break;
                            }
                        }; break;
                    case 3:
                        {
                            int dzień7;
                            Console.WriteLine("\"DE\"Welchen Tag möchten Sie anzeigen? ");
                            dzień7 = Convert.ToInt32(Console.ReadLine());
                            switch (dzień7)
                            {
                                case 1: Console.WriteLine("=> " + dniTygodnia7[14]); break;
                                case 2: Console.WriteLine("=> " + dniTygodnia7[15]); break;
                                case 3: Console.WriteLine("=> " + dniTygodnia7[16]); break;
                                case 4: Console.WriteLine("=> " + dniTygodnia7[17]); break;
                                case 5: Console.WriteLine("=> " + dniTygodnia7[18]); break;
                                case 6: Console.WriteLine("=> " + dniTygodnia7[19]); break;
                                case 7: Console.WriteLine("=> " + dniTygodnia7[20]); break;
                                default:
                                    Console.WriteLine("Es gibt keinen solchen Tag :<"); break;
                            }
                        }; break;
                    default:
                        Console.WriteLine(""); break;
                }

                Console.WriteLine(
                    $"\nWpisz wartość od \"1\" do \"3\" aby wprowadzić nowe dane" +
                    $"\ni powtórzyć wyświetlenie konkretnego dnia tygodnia" +
                    $"\nw danym języku. Jeśli chcesz zakończyć wpisz inną wartość.");
                komenda7 = Convert.ToByte(Console.ReadLine());
            } while (komenda7 == 1 || komenda7 == 2 || komenda7 == 3);

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[10] Niniejszy program obliczaja liczbę wyrazów" +
                $"\nw łańcuchu znaków wprowadzonym przez użytkownika" +
                $"\n[ przyjmuje się tutaj to, iż wyrazy" +
                $"\nto ciągi znaków rozdzielone spacją].\n");

            string wyrazyTekstu;
            Console.WriteLine("Wprowadź dowolny tekst: ");
            wyrazyTekstu = Console.ReadLine();

            int liczbaWyrazówTekstu = 1;
            foreach (char wyraz in wyrazyTekstu)
                if (wyraz == ' ') liczbaWyrazówTekstu++;

            Console.WriteLine("Wprowadzony tekst przez użytkownika zawiera {0} wyrazy/ów", liczbaWyrazówTekstu);

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[11] Niniejszy program wyświetla aktualną godzinę.\n");
            
            string ahaa;
            string baha = "n";
            do
            {
                ahaa = DateTime.Now.ToString("h:mm:ss tt");
                Console.WriteLine(
                    $"Teraz jest godzina: " + ahaa +
                    $"\n\nAby zaktualizować godzinę wpisz" +
                    $"\ndowolną liczbę, cyfrę lub wciśnij enter." +
                    $"\nAby przerwać wpisz \"n\" i naciśnij enter\n");
            } while (!(Console.ReadLine() == baha));

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(
                $"\n\n\n[12] Niniejszy program pobiera datę w formacie DD-MM-RRRR," +
                $"\nz której pobiera miesiąc i wyświetla jego nazwę słownie.\n");
            
            DateTime date = DateTime.Today;
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
            Console.WriteLine(date.ToString("MMMM"));

            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////
            
            Console.ReadKey();
        }

        static void próbatablica2d5x5(int[,] tablica2d5x5)
        // dotyczy => jest to część programu z punktu nr 7 [1-4]
        {
            wyświetltablica2d5x5(tablica2d5x5);
            Console.WriteLine("Rozmiar [wyświetlenie] tablicy dwuwymiarowej: " + tablica2d5x5.Length);
            Console.WriteLine("Suma wszystkich elementów tablicy dwuwymiarowej: " + sumaElementów(tablica2d5x5));
            Console.WriteLine("Suma wszystkich elementów przekątnej tablicy2d: " + sumaElementówPrzekątna(tablica2d5x5));
        }
        static void wyświetltablica2d5x5(int[,] tablica2d5x5)
        // dotyczy => jest to część programu z punktu nr 7 [2-4]
        {
            for (int ini = 0; ini < tablica2d5x5.GetLength(0); ini++)
            {
                for (int jin = 0; jin < tablica2d5x5.GetLength(1); jin++)
                {
                    Console.Write(tablica2d5x5[ini,jin]);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int sumaElementów(int[,] tablica2d)
        // dotyczy => jest to część programu z punktu nr 6 [1-2]
        // dotyczy => jest to część programu z punktu nr 7 [3-4]
        {
            int suma = 0;
            for (int iny = 0; iny < tablica2d.GetLength(0); iny++)
            {
                for (int jen = 0; jen < tablica2d.GetLength(1); jen++)
                {
                    suma += tablica2d[iny, jen];
                }
            }
            return suma;
        }
        static int sumaElementówPrzekątna(int[,] tablica2d)
        // dotyczy => jest to część programu z punktu nr 6 [2-2]
        // dotyczy => jest to część programu z punktu nr 7 [4-4]
        {
            int suma = 0;
            for (int iny =0; iny < tablica2d.GetLength(0); iny++)
            {
                for (int jen = 0; jen < tablica2d.GetLength(1); jen++)
                {
                    if(iny==jen)
                    {
                        suma += tablica2d[iny, jen];
                    }
                }
            }
            return suma;
        }
    }
}
