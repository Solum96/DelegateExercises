using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void IntDelegate(int number);

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

            // ÖVNING 3
            UsesCallback(OnJump);
            Console.ReadKey();

            // ÖVNING 4
            PrintCollection(
                               new List<int> { 1, 2, 3, 4, 5 }, 
                               (number) => { Console.WriteLine("is even index:"+ number); }, 
                               (number) => { Console.WriteLine("is odd index:" + number); }
                           );
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
        public static void UsesCallback(Action callback)
        {
            Console.WriteLine("The rabbit will now jump.");
            callback();
        }

        public static void PrintCollection(List<int> myList, IntDelegate even, IntDelegate odd)
        {
            foreach (var number in myList)
            {
                if (number % 2 == 0) { even(number); }
                else if (number % 2 != 0) { odd(number); }
            }
        }
    }
}
