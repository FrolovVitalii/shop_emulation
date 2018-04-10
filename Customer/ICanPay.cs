using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Customer
{
    interface ICanPay
    {
        bool Pay(double price);
    }
}
