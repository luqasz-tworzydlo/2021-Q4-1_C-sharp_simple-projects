using System;

namespace math_func_and_arit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do something else!!");
            Console.WriteLine("");
            Console.WriteLine("... for example:");
            Console.WriteLine("M A T H  :D");
            Console.WriteLine("");

            Console.WriteLine("Let's calculate the expression for y = '2th root' that contain |sin x| * log of 2 for x");
            Console.WriteLine("I know, I messed up xd ~~~~~~~ idk how to write mathematical symbols xd");
            Console.WriteLine("");

            Console.WriteLine("Anyway... let's begin! :D");

            double x, y;
            Console.WriteLine("Write x (that is greater than 0):");
            x = Convert.ToDouble(Console.ReadLine());
            y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
            /// Console.WriteLine(y);
            /// for tests only

            Console.WriteLine("");
            Console.WriteLine("... and y = " + y + " ^,^");
            Console.WriteLine("");

            int xx = 10, yy;
            yy = (++xx) * 2;
            /// Console.WriteLine(xx);
            /// Console.WriteLine(yy);
            /// for tests only

            Console.WriteLine("Let's calculate y = x * 2 ;)");
            Console.WriteLine("Where x = " + xx + " ;pp");
            /// Console.WriteLine("");
            Console.WriteLine("... and ... ");
            Console.WriteLine("... y = " + yy + " for x = " + xx);
            Console.WriteLine("");

            int xxx, yyy = 7;
            xxx = (yyy += 5);
            /// xxx = ++yyy;
            /// xxx = yyy--;
            ///Console.WriteLine(xxx);
            /// Console.WriteLine(yyy);
            /// for tests only

            Console.WriteLine("Now let's calculate x = (y + 5) ;p");
            Console.WriteLine("... where y = 7 :)");
            Console.WriteLine("... so x = " + xxx + " ;P");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("... and now it's time for some experiments [<,>]");
            Console.WriteLine("");

            int x1, x2, x3, x4, y0;
            Console.WriteLine("Write value for y: ;P");
            y0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            x1 = ++y0;
            Console.WriteLine("For 'x1 = ++y'... x1 = " + x1 + " ... and y = " + y0);
            x2 = y0++;
            Console.WriteLine("For 'x2 = y++'... x2 = " + x2 + " ... and y = " + y0);
            x3 = --y0;
            Console.WriteLine("For 'x3 = y++'... x3 = " + x3 + " ... and y = " + y0);
            x4 = y0--;
            Console.WriteLine("For 'x4 = y++'... x4 = " + x4 + " ... and y = " + y0);

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
