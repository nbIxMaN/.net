using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class CoupleAttribute : Attribute
    {
        public string Pair;
        public double Probability;
        public string ChildType;
    }
}
