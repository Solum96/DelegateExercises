using System;

namespace Delegates
{
    internal class Listener
    {
        string CurrentOrder { get; set; }
        public Listener()
        {
        }

        internal void OnGiveOrder()
        {
            Console.WriteLine("Yaas queen!");
        }
    }
}