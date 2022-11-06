using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.entities
{
    class Bank
    {
        public int code { get; set; }
        public string name { get; set; }
        public Customer[] customers { get; set; }
        public static List<Customer> sortCustomers(Customer[] customers)
        {
            var sortCustomerslist = customers.ToList().OrderBy(c => c.bankAcounts.Length).ToList();
            return sortCustomerslist;
        }

          
    }
}
