using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.entities
{
   public class Bank
    {
        public int code { get; set; }
        public string name { get; set; }
        public List<Customer> customers { get; set; }
        public static List<Customer> sortCustomers(List<Customer> customers)
        {
            var sortCustomerslist = customers.ToList().OrderBy(c => c.bankAcounts.Count).ToList();
            return sortCustomerslist;
        }

        public Bank(int code, string name,List<Customer> customers)
        {
            this.code = code;
            this.name = name;
            this.customers = customers;
        }
    }
}
