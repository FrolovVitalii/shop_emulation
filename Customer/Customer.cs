using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Customer
{
    class CustomerClass : ICanPay, IHasIncome
    {

        private Wallet wallet;

        public CustomerClass()
        {
            wallet = new Wallet();
        }

        public CustomerClass(Wallet wallet)
        {
            this.wallet = wallet;
        }

        public double CheckWallet()
        {
            return wallet.CheckMoney();
        }

        public bool Pay(double price)
        {
            if (CheckWallet() > price)
            {
                return wallet.TakeMoney(price);
            }
            return false;



        }

        public void EarnMoney(double money)
        {
            wallet.PutMoney(money);
        }

        public void LendMoney(double money)
        {
            wallet.PutMoney(money);
        }


        public List<double> CheckWalletTransactions()
        {
            return wallet.GetWalletTransactions();
        }



    }
}
