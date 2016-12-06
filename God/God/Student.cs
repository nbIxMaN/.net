using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    class Student : Human, IPrintableHuman
    {
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
        protected Student() { }
        public Student(string name, string middleName, int age, Sex sex)
        {
            Name = name;
            MiddleName = middleName;
            Age = age;
            Sex = sex;
        }
        public void Print()
        {
            ConsoleColor backGroundcolor = Console.BackgroundColor;
            ConsoleColor foreGroundcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Student: Name {0}, MiddleName {1}, Age {2}, Sex {3}", Name, MiddleName, Age, Sex);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
        }
    }
}
