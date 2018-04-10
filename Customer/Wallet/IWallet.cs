using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Customer
{
    interface IWallet
    {


        double CheckMoney();

        void PutMoney(double money);

        bool TakeMoney(double money);

    }
}
