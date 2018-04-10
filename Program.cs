using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Customer;
using Shop.Shop;
using Shop.ShopAssistant;
using Shop.Storage;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerClass Ivan = new CustomerClass(new Wallet(100));

            Ivan.EarnMoney(300);

            Console.WriteLine($"Ivan has {Ivan.CheckWallet()} money now");

            Ivan.LendMoney(200);

            Console.WriteLine($"Ivan has {Ivan.CheckWallet()} money , after lending");

            var temp = Ivan.Pay(800.11);

            if (temp)
                Console.WriteLine($"Ivan has {Ivan.CheckWallet()} money after some payments.");
            else
                Console.WriteLine("Not enough money in your wallet!");


            Console.WriteLine("Get all transactions with your wallet");

            foreach (var item in Ivan.CheckWalletTransactions())
            {
                Console.WriteLine($" Transaction - {item} ");
            }

            // Console.WriteLine(System.GC.GetTotalMemory(true));
            //Console.WriteLine(Ivan.GetType());

            Console.ReadKey();
        }
    }
}
