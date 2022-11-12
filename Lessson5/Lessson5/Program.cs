using MockContext;
using System;

namespace Lessson5
{
    class Program
    {
        //יפה!!
        //main in program
        static void Main(string[] args)
        {


            mockContextt mock = new mockContextt();
            var q1 = mock.GetBank().customers;
            foreach(var cust in q1)
            {
                foreach(var account in cust.bankAcounts)
                {
                    if (account.ytra > -1)
                        Console.WriteLine(account.AcountNum);
                }
            }
            q1.ForEach(i => i.bankAcounts.ForEach(c => Console.WriteLine(c.AcountNum)));
        }
    }
}
