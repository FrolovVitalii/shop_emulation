using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Customer
{
    class Wallet : IWallet
    {
        // TODO: need to change log transaction.

        private List<double> wallet = new List<double>();

        public Wallet()
        {

        }

        public Wallet(double money)
        {
            this.wallet.Add(money);
        }

        public double CheckMoney()
        {
            return wallet.Sum();
        }

        public void PutMoney(double money)
        {
            this.wallet.Add(money);

        }

        public bool TakeMoney(double money)
        {

            this.wallet.Add(-1.0 * money);
            return true;

        }

        public List<double> GetWalletTransactions()
        {
            return wallet;
        }
    }
}
