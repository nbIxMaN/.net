using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
                Console.WriteLine("Sorry, holiday");
            else
            {
                var numberOfHumans = Int32.Parse(Console.ReadLine());
                God god = new God();
                for(int i = 0; i < numberOfHumans; i++)
                {
                    (god.CreateHuman() as IPrintableHuman).Print();                    
                    Console.WriteLine();
                }
                var humans = god.Humans;
                var pairLine = 2;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                foreach(var human in humans)
                {
                    Console.SetCursorPosition(0, pairLine);
                    (god.CreatePair(human) as IPrintableHuman).Print();
                    pairLine += 2;
                }
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}
