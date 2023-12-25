using System;

namespace boolean_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now we will check if you can go to the theatre. ;p");
            Console.WriteLine("");

            double age, GBP;
            bool theatre;
            Console.WriteLine("Write your age: ");
            age = double.Parse(Console.ReadLine());
            Console.WriteLine("Write your amount of money: ");
            GBP = double.Parse(Console.ReadLine());
            theatre = (age >= 18 && GBP >= 25);

            Console.WriteLine("");
            Console.WriteLine("If you wish to go to the theatre...");
            Console.WriteLine("... you have to be at least 18 years old and have 25 pounds.");
            Console.WriteLine("");
            Console.WriteLine("If TRUE => you can go...");
            Console.WriteLine("If FALSE => you can't go...");
            Console.WriteLine("");

            Console.WriteLine("You have: " + theatre);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("... now it's time for some experiments once again :D");
            Console.WriteLine("");

            Console.WriteLine("Variant no A-1");
            int x1 = 2, y1 = 3;
            bool results1;
            results1 = (x1 >= 3 && y1++ >= 3);
            Console.WriteLine("... and 'results1 = (x1 >= 3 && y1++ >= 3)' ");
            Console.WriteLine("... for x1 = 2 and y1 = 3: ");
            Console.WriteLine("=> Results: " + results1);
            Console.WriteLine("=> x1: " + x1);
            Console.WriteLine("=> y1: " + y1);
            Console.WriteLine("");

            Console.WriteLine("Variant no A-2");
            int x2 = 2, y2 = 3;
            bool results2;
            results2 = (x2 >= 3 & y2++ >= 3);
            Console.WriteLine("... and 'results2 = (x2 >= 3 & y2++ >= 3)' ");
            Console.WriteLine("... for x2 = 2 and y2 = 3: ");
            Console.WriteLine("=> Results: " + results2);
            Console.WriteLine("=> x2: " + x2);
            Console.WriteLine("=> y2: " + y2);
            Console.WriteLine("");

            Console.WriteLine("Variant no A-3");
            int x3 = 2, y3 = 3;
            bool results3;
            results3 = (x3++ >= 3 && y3++ >= 3);
            Console.WriteLine("... and 'results3 = (x3++ >= 3 && y3++ >= 3)' ");
            Console.WriteLine("... for x3 = 2 and y3 = 3: ");
            Console.WriteLine("=> Results: " + results3);
            Console.WriteLine("=> x3: " + x3);
            Console.WriteLine("=> y3: " + y3);
            Console.WriteLine("");

            Console.WriteLine("Variant no A-4");
            int x4 = 2, y4 = 3;
            bool results4;
            results4 = (++x4 >= 3 && y4++ >= 3);
            Console.WriteLine("... and 'results4 = (++x4 >= 3 && y4++ >= 3)' ");
            Console.WriteLine("... for x4 = 2 and y4 = 3: ");
            Console.WriteLine("=> Results: " + results4);
            Console.WriteLine("=> x4: " + x4);
            Console.WriteLine("=> y4: " + y4);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Now let's try something else ;p");
            Console.WriteLine("");

            Console.WriteLine("Variant no B-1");
            int xx1 = 3, yy1 = 9;
            bool results01;
            results01 = (xx1 >= 2 || yy1++ >= 2);
            Console.WriteLine("... and 'results01 = (xx1 >= 2 || yy1++ >= 2)' ");
            Console.WriteLine("... for xx1 = 3 and yy1 = 9: ");
            Console.WriteLine("->> Results: " + results01);
            Console.WriteLine("->> xx1: " + xx1);
            Console.WriteLine("->> yy1: " + yy1);
            Console.WriteLine("");

            Console.WriteLine("Variant no B-2");
            int xx2 = 3, yy2 = 9;
            bool results02;
            results02 = (xx2 >= 2 | yy2++ >= 2);
            Console.WriteLine("... and 'results02 = (xx2 >= 2 | yy2++ >= 2)' ");
            Console.WriteLine("... for xx2 = 3 and yy2 = 9: ");
            Console.WriteLine("->> Results: " + results02);
            Console.WriteLine("->> xx2: " + xx2);
            Console.WriteLine("->> yy2: " + yy2);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("... I know, nothing facsinating has happened xd");
            Console.WriteLine("Now it's our last experiment :<");
            Console.WriteLine("");

            Console.WriteLine("Variant no C-1");
            int xxx1 = 1, yyy1 = 2, zzz1 = 3;
            bool resultsR1;
            resultsR1 = (xxx1 == 1 || yyy1 != 5 && zzz1 < 1);
            Console.WriteLine("... and 'resultsR1 = (xxx1 == 1 || yyy1 != 5 && zzz1 < 1)' ");
            Console.WriteLine("... for xxx1 = " + xxx1 + ", yyy1 = " + yyy1 + " and zzz1 = " + zzz1 + " : ");
            Console.WriteLine("=> Results: " + resultsR1);
            Console.WriteLine("");

            Console.WriteLine("Variant no C-2");
            int xxx2 = 1, yyy2 = 2, zzz2 = 3;
            bool resultsR2;
            resultsR2 = ((xxx2 == 1 || yyy2 != 5) && zzz2 < 1);
            /// (xxx2 == 1 || yyy2 != 5) <- first
            /// && zzz2 <- second
            Console.WriteLine("... and 'resultsR2 = ((xxx2 == 1 || yyy2 != 5) && zzz2 < 1)' ");
            Console.WriteLine("... for xxx2 = " + xxx2 + ", yyy2 = " + yyy2 + " and zzz2 = " + zzz2 + " : ");
            Console.WriteLine("=> Results: " + resultsR2);
            Console.WriteLine("");

            Console.WriteLine("Variant no C-3");
            int xxx3 = 1, yyy3 = 2, zzz3 = 3;
            bool resultsR3;
            resultsR3 = !(xxx3 == 1 || yyy3 != 5 && zzz3 < 1);
            Console.WriteLine("... and 'resultsR3 = !(xxx3 == 1 || yyy3 != 5 && zzz3 < 1)' ");
            Console.WriteLine("... for xxx3 = " + xxx3 + ", yyy3 = " + yyy3 + " and zzz3 = " + zzz3 + " : ");
            Console.WriteLine("=> Results: " + resultsR3);
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
