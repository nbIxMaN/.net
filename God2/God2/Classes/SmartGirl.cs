using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    [Couple(Pair = "Student", Probability = 0.2, ChildType = "Girl")]
    [Couple(Pair = "Botan", Probability = 0.5, ChildType = "Book")]
    public sealed class SmartGirl : Girl, IPrintable
    {
        public string CallChild()
        {
            return RandomHelper.GetRandomWomanName();
        }
        public string MiddleName { get; }
        public SmartGirl()
        {
            Sex = Sex.female;
        }
        public SmartGirl(string name, string middleName, int age)
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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SmartGirl: Name {0}, MiddleName {1}, Age {2}, Sex {3}", Name, MiddleName, Age, Sex);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
        }
    }
}
