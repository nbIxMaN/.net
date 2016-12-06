using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    [Couple(Pair = "Girl", Probability = 0.7, ChildType = "Girl")]
    [Couple(Pair = "PrettyGirl", Probability = 1, ChildType = "PrettyGirl")]
    [Couple(Pair = "SmartGirl", Probability = 0.8, ChildType = "Book")]
    public class Botan : Student, IPrintable
    {
        public string CallChild()
        {
            return RandomHelper.GetRandomWomanName();
        }
        private double averageRating;
        public double AverageRating
        {
            get
            {
                return averageRating;
            }
            set
            {
                averageRating = value;
            }
        }
        public Botan()
        {
            Sex = Sex.male;
        }
        public Botan(string name, string middleName, int age, double averageRating)
        {
            Name = name;
            MiddleName = middleName;
            Age = age;
            Sex = Sex.male;
            AverageRating = averageRating;
        }
        public void Print()
        {
            ConsoleColor backGroundcolor = Console.BackgroundColor;
            ConsoleColor foreGroundcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Botan: Name {0}, MiddleName {1}, Age {2}, Sex {3}, AverageRating {4}", Name, MiddleName, Age, Sex, AverageRating);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
        }
    }
}
