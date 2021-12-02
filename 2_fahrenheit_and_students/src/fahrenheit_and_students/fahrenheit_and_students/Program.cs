using System;

namespace fahrenheit_and_students
{
    class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Write a specific Fahrenheit degree:");

            F = double.Parse(Console.ReadLine());
            C = 5d / 9 * (F - 32);
            /// Console.WriteLine(C);
            /// powyższy kod użyty do testu

            Console.WriteLine("");
            Console.WriteLine("... and " + F + "°F it's: " + C + " °C");
            Console.WriteLine("");

            Console.WriteLine("Now, let's try to convert degrees Celsius to Fahrenheit! :)");
            Console.WriteLine("");
            Console.WriteLine("Write a specific temperature unit in Celsius degree:");

            double C2, F2;
            C2 = double.Parse(Console.ReadLine());
            F2 = (9.0 / 5) * C2 + 32;

            Console.WriteLine("");
            Console.WriteLine("... and " + C2 + "°C it's: " + F2 + " °F");
            Console.WriteLine("");

            Console.WriteLine("Now we will check how many chair/s can have a one student ;p");

            const int chairs = 12;
            int students;
            double results;
            Console.WriteLine("Write a specific amount of students:");
            students = Convert.ToInt32(Console.ReadLine());
            results = (double)chairs / students;
            /// Console.WriteLine(results);
            /// testing if a code works

            Console.WriteLine("");
            Console.WriteLine("Every student can have only: " + results + " chair/s {:<");
            Console.WriteLine("We have only " + chairs + " chairs :<<<");

            Console.ReadKey();
        }
    }
}
