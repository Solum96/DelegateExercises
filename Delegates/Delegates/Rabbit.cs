using System;

namespace Delegates
{
    internal class Rabbit
    {
        public event Action Jump;
        public event Action Squeek;

        public Rabbit()
        {
        }

        public void DoJump()
        {
            Console.WriteLine("this Rabbit jumps");
            Jump();
        }
        public string DoSqueek()
        {
            Squeek();
            return "Squeeeeek";
        }
    }
}