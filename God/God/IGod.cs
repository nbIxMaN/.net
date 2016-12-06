using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    interface IGod
    {
        Human CreateHuman();
        Human CreateHuman(Sex gender);
        Human CreatePair(Human human);
    }
}
