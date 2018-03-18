using System;

namespace ChainOfResponsiblity.Process
{
    public class InventoryProcess<Mobile>
    {
        public void placeOrder(Mobile o)
        {
            Console.WriteLine("Order placed for mobile {0}", o.ToString());
            //Place the order.
        }

        public void defaultOrder(Mobile o)
        {
            Console.WriteLine("The order is not placed for the mobile {0}", o.ToString());
            //Place the order.
        }
    }
}