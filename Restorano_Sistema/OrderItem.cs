using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorano_Sistema
{
    internal class OrderItem
    {
        public string OderID { get; set; }
        public string ProductID { get; set; }

        public OrderItem (string oderID, string productID)
        {
            OderID = oderID;
            ProductID = productID;
        }
    }
}
