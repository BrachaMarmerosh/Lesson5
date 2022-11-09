using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.entities
{
    public class Customer
    {
        public string tz { get; set; }
        public string name { get; set; }
        public List<BankAcount> bankAcounts { get; set; }

        public Customer(string tz, string name, List<BankAcount> bankAcounts)
        {
            this.tz = tz;
            this.name = name;
            this.bankAcounts = bankAcounts;
        }

        public static Customer FindCustomerByTz(List<Customer> c,string tz)
        {
            var q = c.Find(i => i.tz == tz);
            return q;
        }
       
     

         
    }
}
