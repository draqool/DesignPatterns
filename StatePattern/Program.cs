using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account(() => Console.WriteLine("unfreezed"));
            account.Deposit(1000);
            account.Freeze();
            account.Withdraw(200);
     
            Console.ReadKey();
        }
    }
}
