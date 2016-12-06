using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    [Couple(Pair = "Student", Probability = 0.4, ChildType = "PrettyGirl")]
    [Couple(Pair = "Botan", Probability = 0.1, ChildType = "PrettyGirl")]
    public sealed class PrettyGirl : Girl, IPrintable
    {
        public string CallChild()
        {
            return RandomHelper.GetRandomWomanName();
        }

        public string MiddleName { get; set; }

        public PrettyGirl()
        {
            Sex = Sex.female;
        }
        public PrettyGirl(string name, string middleName, int age)
        {
            Name = name;
            Age = age;
            Sex = Sex.female;
            MiddleName = middleName;
        }
        public void Print()
        {
            var backGroundcolor = Console.BackgroundColor;
            var foreGroundcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("PrettyGirl: Name {0}, MiddleName {1}, Age {2}, Sex {3}", Name, MiddleName, Age, Sex);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
        }
    }
}
