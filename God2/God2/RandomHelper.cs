using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    static class RandomHelper
    {
#if DEBUG
        static Random random = new Random(0);
#else
        static Random random = new Random();
#endif
        public static Random Random
        {
            get
            {
                return random;
            }
        }
        static string[] manName = { "Антон", "Максим", "Алксандр", "Глеб", "Зигмунд", "Константин" };
        static string[] womanName = { "Анна", "Виктория", "Екатерина", "Мария", "Любовь", "Юлия" };
        const int minimalStudentAge = 16;
        static Sex[] sexArray = (Sex[])Enum.GetValues(typeof(Sex));
        static HumanType[] manTypes = { HumanType.Student, HumanType.Botan };
        static HumanType[] womanTypes = { HumanType.Girl, HumanType.PrettyGirl, HumanType.SmartGirl };
        public static string GetRandomWomanName()
        {
            return womanName[random.Next(womanName.Length)];
        }
        public static string GetRandomManName()
        {
            return manName[random.Next(manName.Length)];
        }
        public static string GetRandomWomanMiddleName()
        {
            return manName[random.Next(manName.Length)] + "овна";
        }
        public static string GetRandomManMiddleName()
        {
            return manName[random.Next(manName.Length)]+ "ович";
        }
        public static int GetRandomAge()
        {
            return minimalStudentAge + random.Next(8);
        }
        public static Sex GetRandomSex()
        {
            return sexArray[random.Next(sexArray.Length)];
        }
        public static HumanType GetRandomManType()
        {
            return manTypes[random.Next(manTypes.Length)];
        }
        public static HumanType GetRandomWomanType()
        {
            return womanTypes[random.Next(womanTypes.Length)];
        }
        public static double GetRandomAverageRating()
        {
            return 3 + random.Next(2) + random.NextDouble();
        }
    }
}
