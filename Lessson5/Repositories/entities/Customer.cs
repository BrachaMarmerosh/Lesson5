using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.entities
{
    class Customer
    {
        public string tz { get; set; }
        public string name { get; set; }
        public BankAcount[] bankAcounts { get; set; }

        public static Customer FindCustomerByTz(Customer[] c,string tz)
        {
            var q = c.ToList().Find(i => i.tz == tz);
            return q;
        }
    }
}
