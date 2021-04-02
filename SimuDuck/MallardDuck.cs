using System;
using SimuDuck.Impl;

namespace SimuDuck
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quacking();
        }

        public void Display()
        {
            Console.WriteLine("I'm a real Mallard duck!");
        }
    }
}