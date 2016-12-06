using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataValidator;

namespace valid
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            while (str != null && !str.Equals("exit"))
            {
                str = Console.ReadLine();
                switch (Checker.CheckData(str))
                {
                    case DataEnum.TelephonNumber:
                        Console.WriteLine("{0} is telephone number", str);
                        break;
                    case DataEnum.USAPostIndex:
                        Console.WriteLine("{0} is USA post index", str);
                        break;
                    case DataEnum.RussianPostIndex:
                        Console.WriteLine("{0} is russian post index", str);
                        break;
                    case DataEnum.Email:
                        Console.WriteLine("{0} is EMail", str);
                        break;
                    default:
                        Console.WriteLine("{0} is unknown data", str);
                        break;
                }
            }
        }
    }
}
