using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    public abstract class Human : IHasName
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
        private bool inLove;
        public bool InLove
        {
            get
            {
                return inLove;
            }
            set
            {
                inLove = value;
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
