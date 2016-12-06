using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    class CoolParent : Parent, IPrintableHuman
    {
        private double money;
        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public CoolParent() { 
}
        public CoolParent(string name, int age, Sex sex, int numberOfChild, double money)
        {
            Name = name;
            Age = age;
            Sex = sex;
            NumberOfChild = numberOfChild;
            Money = money;
        }
        public void Print()
        {
            ConsoleColor backGroundcolor = Console.BackgroundColor;
            ConsoleColor foreGroundcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("CoolParent: Name {0}, Age {1}, Sex {2}, NumberOfChild {3} Money ", Name, Age, Sex, NumberOfChild);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(Money);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
            Console.WriteLine();
        }
    }
}
