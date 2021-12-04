using System;

namespace if_else_do_while_for_PP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do something useful this time! :>");
            Console.WriteLine("... like conditional statements \nand repeating instructions ;>>>");
            Console.WriteLine("");
            Console.WriteLine("... but let's use the Polish language ;p");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("< 1 > Instrukcja warunkowa => if...else");
            Console.WriteLine("");

            double współczynnikKierunkowy, wyrazWolny;
            Console.WriteLine("Podaj współczynnik kierunkowy prostej a = \n\t[ wpisz wartość dodatnią lub ujemną ]");
            współczynnikKierunkowy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wyraz wolny prostej b = \n\t[ wpisz wartość dodatnią lub ujemną ]");
            wyrazWolny = Convert.ToDouble(Console.ReadLine());
            if (współczynnikKierunkowy == 0)
                if (wyrazWolny == 0)
                    Console.WriteLine("Miejscem zerowym prostej y = 0 jest każdy x");
                else
                    Console.WriteLine(
                        $"prosta y = {wyrazWolny} nie ma miejsc zerowych");
            else
                Console.WriteLine(
                    $"Miejscem zerowym prostej " +
                    $"y = {współczynnikKierunkowy}x + {wyrazWolny}" +
                    $" jest {(-1*współczynnikKierunkowy) / wyrazWolny}");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("< 2 > Instrukcja cykliczna \n=> pętla do-while");
            Console.WriteLine("");

            do
            {
                Console.WriteLine(
                    "Jestem w pędli do-while.\n " +
                    "Instrukcje do-while wykonują się co najmniej raz\n" +
                    "Wpisz \"1\" jeśli chcesz kontynuować"
                    );
            } while (Convert.ToByte(Console.ReadLine()) == 1);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("< 3 > Instrukcja cykliczna \n=> pętla for");
            Console.WriteLine("");

            Console.WriteLine("Ile razy wykonać pętlę?");
            for (
                int k = 0, n = Convert.ToInt32(Console.ReadLine());
                k < n;
                k += 1
                )
                Console.WriteLine("=> " + k);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("< 4 > Instrukcja cykliczna \n=> pętla do-while");
            Console.WriteLine("");

            byte komenda1;
            do
            {
                Console.WriteLine("Wpisz \"0\" lub \"1\" żeby kontynuować pętlę");
                komenda1 = Convert.ToByte(Console.ReadLine());
            }
            while (komenda1 == 0 || komenda1 == 1);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("< 5 > Instrukcja cykliczna \n=> pętla do-while");
            Console.WriteLine("");

            byte komenda2;
            do
            {
                Console.WriteLine("Wpisz \"0\" lub \"1\" żeby przerwać pętlę");
                komenda2 = Convert.ToByte(Console.ReadLine());
                if (komenda2 == 0)
                {
                    Console.WriteLine("Wpisałeś 0 więc przerywam");
                    break;
                }
                else if (komenda2 == 1)
                {
                    Console.WriteLine("Wpisałeś 1 więc przerywam");
                    break;
                }

            } while (true);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("<[|,|]> Wykorzystano poniżej: ");
            Console.WriteLine("< *** > Instrukcję cykliczna => pętla do-while");
            Console.WriteLine("< *** > Instrukcję warunkowa => if...else");

            byte komenda0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Możesz tutaj wyliczyć miejsca zerowe\ndla funkcji kwadratowej ^>^");
                Console.WriteLine("");
                double współczynnikKierunkowyA, współczynnikKierunkowyB, wyrazWolnyC, delta;
                Console.WriteLine("Podaj współczynnik kierunkowy prostej a = ");
                współczynnikKierunkowyA = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj współczynnik kierunkowy prostej b = ");
                współczynnikKierunkowyB = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wyraz wolny prostej c = ");
                wyrazWolnyC = Convert.ToDouble(Console.ReadLine());
                delta = ((współczynnikKierunkowyB * współczynnikKierunkowyB) - (4 * współczynnikKierunkowyA * wyrazWolnyC));
                if (współczynnikKierunkowyA == 0)
                    if (współczynnikKierunkowyB == 0)
                        if (wyrazWolnyC == 0)
                            Console.WriteLine("Miejscem zerowym prostej f[x] = ax2+bx+c jest każdy x");
                        else
                            Console.WriteLine($"prosta y = {współczynnikKierunkowyA} nie ma miejsc zerowych");
                    else
                        Console.WriteLine($"prosta y = {współczynnikKierunkowyB} nie ma miejsc zerowych");
                else if (delta < 0)
                    Console.WriteLine(
                        $"=> Nie ma miejsc zerowych" +
                        $"\nFunkcja kwadratowa " +
                        $"y = {współczynnikKierunkowyA}x2 + {współczynnikKierunkowyB}x + {wyrazWolnyC}" +
                        $" dla delty {delta} nie ma miejsc zerowych");
                else if (delta == 0)
                    Console.WriteLine(
                        $"=> Jest jedno miejsce zerowe" +
                        $"\nMiejscem zerowym dla funkcji kwadratowej " +
                        $"y = {współczynnikKierunkowyA}x2 + {współczynnikKierunkowyB}x + {wyrazWolnyC}" +
                        $"dla delty {delta} " +
                        $" jest x = {(-1 * współczynnikKierunkowyB) / (2 * współczynnikKierunkowyA)}");
                else if (delta > 0)
                {
                    Console.WriteLine("=> Są dwa miejsca zerowe");
                    Console.WriteLine(
                        $"Miejsca zerowe dla funkcji kwadratowej " +
                        $"y = {współczynnikKierunkowyA}x2 + {współczynnikKierunkowyB}x + {wyrazWolnyC}" +
                        $"\ndla delty {delta} i pierwiastka z delty {Math.Sqrt(delta)}" +
                        $"\nsą x1 = {((-1 * współczynnikKierunkowyB) * (-1 * Math.Sqrt(delta))) / (2 * współczynnikKierunkowyA)}" +
                        $" oraz x2 = {((-1 * współczynnikKierunkowyB) * Math.Sqrt(delta)) / (2 * współczynnikKierunkowyA)}");
                }
                Console.WriteLine("\nWpisz wartość od \"1\" do \"9\" aby wprowadzić nowe dane i powtórzyć obliczenia \nJeśli chcesz zakończyć program wpisz \"0\"");
                komenda0 = Convert.ToByte(Console.ReadLine());
            }
            while (komenda0 == 1 || komenda0 == 2 || komenda0 == 3 || komenda0 == 4 || komenda0 == 5 || komenda0 == 6 || komenda0 == 7 || komenda0 == 8 || komenda0 == 9);

            Console.WriteLine("");
            Console.WriteLine("... i to wszystko już na dziś :>");
            Console.WriteLine("I hope you understand what I did ;>>");
            
            Console.ReadKey();
        }
    }
}
