using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    [Couple(Pair = "Student", Probability = 0.7, ChildType = "Girl")]
    [Couple(Pair = "Botan", Probability = 0.3, ChildType = "SmartGirl")]
    public class Girl : Human, IPrintable
    {
        public string CallChild()
        {
            return RandomHelper.GetRandomWomanName();
        }
        private string middleName { get; set; }
        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }
        public Girl()
        {
            Sex = Sex.female;
        }
        public Girl(string name, string middleName, int age)
        {
            Name = name;
            Age = age;
            Sex = Sex.female;
            MiddleName = middleName;
        }
        public void Print()
        {
            ConsoleColor backGroundcolor = Console.BackgroundColor;
            ConsoleColor foreGroundcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Girl: Name {0}, MiddleName {1}, Age {2}, Sex {3}", Name, MiddleName, Age, Sex);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
        }
    }
}
