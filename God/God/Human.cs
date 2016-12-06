using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public enum Sex
    {
        male,
        female
    }
    abstract class Human
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
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        private Sex sex;
        public Sex Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }
        protected Human() { }
        public Human(string name, int age, Sex sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }
    }
}
