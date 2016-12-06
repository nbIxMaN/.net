using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    class Parent : Human, IPrintableHuman
    {
        private int numberOfChild { get; set; }
        public int NumberOfChild
        {
            get
            {
                return numberOfChild;
            }
            set
            {
                numberOfChild = value;
            }
        }
        protected Parent() { }
        public Parent(string name, int age, Sex sex, int numberOfChild)
        {
            Name = name;
            Age = age;
            Sex = sex;
            NumberOfChild = numberOfChild; 
        }
        public void Print()
        {
            ConsoleColor backGroundcolor = Console.BackgroundColor;
            ConsoleColor foreGroundcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Parent: Name {0}, Age {1}, Sex {2}, NumberOfChild {3} ", Name, Age, Sex, NumberOfChild);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
        }
    }
}
