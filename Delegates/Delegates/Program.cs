using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {

            // ÖVNING 1
            Rabbit bengt = new Rabbit();
            bengt.Jump += OnJump;
            bengt.Squeek += OnSqueek;

            bengt.DoJump();
            Console.WriteLine(bengt.DoSqueek());
            Console.ReadKey();

            // ÖVNING 2
            Speaker speaker = new Speaker();
            Listener listener = new Listener();

            speaker.Order += listener.OnGiveOrder;
            speaker.GiveOrder("Do this.");
            Console.ReadKey();
        }

        private static void OnSqueek()
        {
            Console.WriteLine("The rabbit seems frightened.");
        }

        public static void OnJump()
        {
            Console.WriteLine("The rabbit jumped!");
        }
    }
}
