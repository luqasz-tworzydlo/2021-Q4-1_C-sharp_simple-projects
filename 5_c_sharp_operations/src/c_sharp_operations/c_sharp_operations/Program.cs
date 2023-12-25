using System;

namespace c_sharp_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's introduce ourselves to each other! ^,^");
            Console.WriteLine("");

            string text0, text1;
            Console.WriteLine("Write your name, please: ");
            text0 = Console.ReadLine();
            text1 = "Hi " + text0 + "!";
            Console.WriteLine(text1 + " Nice to meet you :>");
            Console.WriteLine("By the way I'm Lukasz :P");
            Console.WriteLine("");
            Console.WriteLine("Do you know that your name has " + text0.Length + " words?");

            Console.WriteLine("");

            string text2;
            Console.WriteLine("... and what's your second name? ;p");
            text2 = Console.ReadLine();
            Console.WriteLine(text2 + " " + "C-19");
            Console.WriteLine("... are you? :o");

            Console.WriteLine("");
            Console.WriteLine("Let's do something else xD");
            Console.WriteLine("");

            Console.WriteLine("Test no A-1");
            string textA1 = "Halley's Comet ";
            string resultsA1 = textA1 + "18";
            Console.WriteLine(resultsA1);
            Console.WriteLine("");

            Console.WriteLine("Test no A-2");
            string textA2 = "Halley's Comet ";
            string resultsA2 = textA2 + 03;
            Console.WriteLine(resultsA2);
            Console.WriteLine("");

            Console.WriteLine("Test no A-3");
            Console.WriteLine(18 + 03);
            Console.WriteLine("");

            Console.WriteLine("Test no A-4");
            Console.WriteLine("18" + 03);
            Console.WriteLine("");

            Console.WriteLine("Test no A-5");
            char characterA5 = 'C';
            Console.WriteLine("H" + characterA5);
            Console.WriteLine("");

            Console.WriteLine("Test no A-6");
            char characterA6 = 'C';
            Console.WriteLine('H' + characterA6);
            Console.WriteLine("");

            // h => 72
            // c => 67

            Console.WriteLine("Test no A-7");
            Console.WriteLine("Sum=" + 3 + 3 + " & Product=" + 3 * 3);
            Console.WriteLine("");

            Console.WriteLine("Test no A-8");
            Console.WriteLine("Sum=" + (3 + 3) + " & Product=" + 3 * 3);
            Console.WriteLine("");

            // Sum -> Suma
            // Product -> Iloczyn

            Console.WriteLine("... for more check out C# code ;p");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("... and a little more :p");
            Console.WriteLine();

            Console.WriteLine("C1\nC2"); // przejście do nowej linii => \n
            Console.WriteLine("Height: 178\tWeight 94"); // tabulacja => \t
            Console.WriteLine(@"Height: 178\tWeight 94"); // dosłowna interpretacja => @
            Console.WriteLine("C:\\Windows\\Temp"); // podwójny znak "\\" wstawia "\"
            Console.WriteLine("Movie Title: \"IDK\""); // znak \" wstawia znak "
            Console.WriteLine("");

            Console.WriteLine("Now let's see triggers and order of execution ;ppp");
            Console.WriteLine("");

            Console.WriteLine("Test no B-1");
            int a, b, c = 18;
            a = b = c; // operacja od prawej do lewej
            Console.WriteLine(a);
            Console.WriteLine(a + b + c); // operacja od lewej do prawej

            Console.WriteLine("");

            Console.WriteLine("Test no B-2");
            int tra = 1, lala = 1;
            Console.WriteLine(tra++ + 2 * ++lala);

            Console.WriteLine("");
            Console.WriteLine("... and of course ... ");
            Console.WriteLine("... for more check out C# code :>");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Let's take a look at the presentation of the results... in C# ;ppp");

            Console.WriteLine("");

            Console.WriteLine("Test no C-1");
            int ex = 1939, ey = 1945;
            Console.WriteLine("Sum=" + ex + " Product=" + ey);
            Console.WriteLine("Sum={0} Product={1}", ex, ey);
            Console.WriteLine("");

            Console.WriteLine("Test no C-2");
            int summ = 12;
            double xX = 12.233445, yY = 23.34, indicator = 0.34;
            string name = "Avant", surname = "de Venir";
            Console.WriteLine("1. Name: {0,15} Surname: {1,20}", name, surname);
            Console.WriteLine("2. Name: {0,-15} Surname: {1,-20}", name, surname);
            Console.WriteLine("3. Value {0, 10} is a sum", summ);
            Console.WriteLine("4. Value {0, -10} is a sum", summ);
            Console.WriteLine("5. Indicator: {0,8:P}", indicator);
            Console.WriteLine("6. Weight: {0,10} kg", xX);
            Console.WriteLine("7. {0,-10:F4} (4 digits after the decimal point)", xX);
            Console.WriteLine("8. Value x={0,-10:F4} y={1,-10:F2}", xX, yY);
            Console.WriteLine("9. And this number will be in braces {{{0}}}", yY);

            Console.WriteLine("");
            Console.WriteLine("Test no C-3");
            Console.WriteLine("Sum={0} ", 20);
            Console.WriteLine("Product={0} ", 21);

            Console.WriteLine("");
            Console.WriteLine(";ppppppp");
            Console.WriteLine("... and check out C# code ;>>");

            Console.ReadKey();
        }
    }
}
