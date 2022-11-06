using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.entities
{
    class BankAcount
    {
        private int acountNum;

        public int AcountNum
        {
            get { return acountNum; }
            set {if(value.IsOdd())
                    acountNum = value; }
        }

        public int ytra { get; set; }
        public int afkada { get; set; }
        public int meshicha { get; set; }
    }
}
