using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God2
{
    interface IGod
    {
        Human CreateHuman();
        Human CreateHuman(Sex gender);
        IHasName Couple(Human firstHuman, Human secondHuman);
    }
}
