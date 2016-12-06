using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    [Couple(Pair = "Girl", Probability = 0.7, ChildType ="Girl")]
    [Couple(Pair = "PrettyGirl", Probability = 1, ChildType = "PrettyGirl")]
    [Couple(Pair = "SmartGirl", Probability = 0.5, ChildType ="Girl")]
    public class Student : Human, IPrintable
    {
        public string CallChild()
        {
            return RandomHelper.GetRandomWomanName();
        }
        public string MiddleName { get; set; }
        public Student()
        {
            Sex = Sex.male;
        }
        public Student(string name, string middleName, int age)
        {
            Name = name;
            MiddleName = middleName;
            Age = age;
            Sex = Sex.male;
        }
        public void Print()
        {
            var backGroundcolor = Console.BackgroundColor;
            var foreGroundcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student: Name {0}, MiddleName {1}, Age {2}, Sex {3}", Name, MiddleName, Age, Sex);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
        }
    }
}
