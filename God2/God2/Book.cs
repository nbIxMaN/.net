using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    class Book : IHasName, IPrintable
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Book() { }
        public Book(string name)
        {
            Name = name;
        }
        public void Print()
        {
            ConsoleColor backGroundcolor = Console.BackgroundColor;
            ConsoleColor foreGroundcolor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Book: Name {0}", Name);
            Console.ForegroundColor = foreGroundcolor;
            Console.BackgroundColor = backGroundcolor;
        }
    }
}
