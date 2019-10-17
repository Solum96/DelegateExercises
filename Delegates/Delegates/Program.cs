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
            Rabbit bengt = new Rabbit();
            bengt.Jump += OnJump;
            bengt.Squeek += OnSqueek;

            bengt.DoJump();
            Console.WriteLine(bengt.DoSqueek());
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
