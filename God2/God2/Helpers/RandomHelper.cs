using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    internal static class RandomHelper
    {
#if DEBUG
#else
        static Random random = new Random();
#endif
        public static Random Random { get; } = new Random(0);

        private static readonly string[] ManName = { "Антон", "Максим", "Алксандр", "Глеб", "Зигмунд", "Константин" };
        private static readonly string[] WomanName = { "Анна", "Виктория", "Екатерина", "Мария", "Любовь", "Юлия" };
        private const int MinimalStudentAge = 16;
        private static readonly Sex[] SexArray = (Sex[])Enum.GetValues(typeof(Sex));
        private static readonly HumanType[] ManTypes = { HumanType.Student, HumanType.Botan };
        private static readonly HumanType[] WomanTypes = { HumanType.Girl, HumanType.PrettyGirl, HumanType.SmartGirl };
        public static string GetRandomWomanName()
        {
            return WomanName[Random.Next(WomanName.Length)];
        }
        public static string GetRandomManName()
        {
            return ManName[Random.Next(ManName.Length)];
        }
        public static string GetRandomWomanMiddleName()
        {
            return ManName[Random.Next(ManName.Length)] + "овна";
        }
        public static string GetRandomManMiddleName()
        {
            return ManName[Random.Next(ManName.Length)]+ "ович";
        }
        public static int GetRandomAge()
        {
            return MinimalStudentAge + Random.Next(8);
        }
        public static Sex GetRandomSex()
        {
            return SexArray[Random.Next(SexArray.Length)];
        }
        public static HumanType GetRandomManType()
        {
            return ManTypes[Random.Next(ManTypes.Length)];
        }
        public static HumanType GetRandomWomanType()
        {
            return WomanTypes[Random.Next(WomanTypes.Length)];
        }
        public static double GetRandomAverageRating()
        {
            return 3 + Random.Next(2) + Random.NextDouble();
        }
    }
}
