using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.entities
{
    static class Extension
    {
        public static bool IsOdd(this int x) => x % 2==0;
    }
}
