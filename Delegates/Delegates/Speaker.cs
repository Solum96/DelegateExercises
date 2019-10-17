using System;

namespace Delegates
{
    internal class Speaker
    {
        public event Action Order;
        public Speaker()
        {
        }

        public void GiveOrder(string order)
        {
            Console.WriteLine(order);
            Order();
        }

    }
}