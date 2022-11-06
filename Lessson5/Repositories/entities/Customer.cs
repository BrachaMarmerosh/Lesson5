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

        public static Customer FindCustomerByTz(Customer[] customers,string tz)
        {
            var cu=customers.ToList().Where(c => c.tz == tz);
            return cu;
        }
    }
}
