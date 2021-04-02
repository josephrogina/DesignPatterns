using System;

namespace SimuDuck
{
    public class Quacking : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}