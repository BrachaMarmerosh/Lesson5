using Repositories.entities;
using System;
using System.Collections.Generic;

using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MockContext
{
    public class mockContextt
    {
        Bank bank = new Bank(139, "Discount",
          new List<Customer>
          {
            new Customer("123","Jacob",new List<BankAcount>{new BankAcount(2,100,50,50)}),
            new Customer("465","Rachel",new List<BankAcount>{ new BankAcount( 4, 1000, 500, 500 ) })
           });


        public Bank GetBank()
        {
            return bank;
        }
    }
}
