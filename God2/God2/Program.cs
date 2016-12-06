using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace God2
{
    internal class Program
    {
        private static readonly God God = new God();

        private static void Main(string[] args)
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("Sorry, holiday");
            else {
                ConsoleKeyInfo key;
                do
                {
                    key = System.Console.ReadKey();
                    if (key.Key != ConsoleKey.Enter) continue;
                    var one = God.CreateHuman();
                    var two = God.CreateHuman();
                    try
                    {
                        var child = God.Couple(one, two);
                        var printable1 = one as IPrintable;
                        printable1?.Print();
                        var printable2 = two as IPrintable;
                        printable2?.Print();
                        Console.WriteLine("{0} Inlove {1}, {2} Inlove {3}", one.Name, one.InLove, two.Name, two.InLove);
                        if (child != null)
                        {
                            var printable = child as IPrintable;
                            printable?.Print();
                        }
                        Console.WriteLine();
                    }
                    catch (HomosexualExeption)
                    {
                        var printable1 = one as IPrintable;
                        printable1?.Print();
                        var printable2 = two as IPrintable;
                        printable2?.Print();
                        Console.WriteLine("Illegal relationship");
                        Console.WriteLine();
                    }
                } while (key.Key != ConsoleKey.Q && key.Key != ConsoleKey.F10);
            }
        }
    }
}
