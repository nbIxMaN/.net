using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    class Botan : Student, IPrintableHuman
    {
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
        protected Botan() { }
        public Botan(string name, string middleName, int age, Sex sex, double averageRating)
        {
            Name = name;
            MiddleName = middleName;
            Age = age;
            Sex = sex;
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
