using System;

namespace our_lucky_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visual Studio 2019 projects began!");
            Console.WriteLine("");
            Console.WriteLine("cw + tab => Console.WriteLine ;)");
            Console.WriteLine("");

            int x;
            x = 3;
            Console.WriteLine("My lucky number: " + x + " :)");

            int y = 4, z;
            Console.WriteLine("... and " + (x + y) + " also! ;)");
            Console.WriteLine("");

            Console.WriteLine("Write your lucky number too: " + " :)");
            z = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("... and we know that " + z + " is your lucky number! ;P");
            Console.WriteLine("");

            int a, b, wynik;
            a = (x + y);
            b = 5;
            wynik = (2 * a + 2 * b) / 2 + (z - z);

            Console.WriteLine("Btw do you know that one year is equal to " + wynik + " months?");
            Console.WriteLine("... well, now you do ;PPP");
            Console.WriteLine("");
            Console.WriteLine("... and as a reminder: ");
            Console.WriteLine("1 year = " + wynik + " months ;p");

            Console.ReadKey();
        }
    }
}
