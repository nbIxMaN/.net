using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    public abstract class Human : IHasName
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Sex Sex { get; set; }

        public bool InLove { get; set; }

        protected Human() { }

        protected Human(string name, int age, Sex sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
    }
}
