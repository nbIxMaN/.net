using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public static class RandomHelper
    {
        public static readonly Random random = new Random();
        private const int TimeSleep = 11000;
        private const int TimePass = 4000;
        private const int Marks = 4;
        private const int Students = 31;
        private static readonly string[] Names = {"Иван", "Петр", "Михаил", "Константин", "Глеб"};
        private static readonly string[] LastNames = { "Перов", "Романов", "Распутин", "Шульев", "Йошкин" };
        public static int RandomTimeSleep => random.Next(TimeSleep);
        public static int RandomTimePass => random.Next(TimePass);
        public static int RandomMarks => 2 + random.Next(Marks);
        public static int RandomStudents { get; private set; } = 0;

        public static void Reset()
        {
            RandomStudents = random.Next(Students);

        }
        public static string RandomName => Names[random.Next(Names.Length)];
        public static string RandomFamily => LastNames[random.Next(LastNames.Length)];
    }
}
