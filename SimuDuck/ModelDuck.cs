using SimuDuck.Impl;
using System;

namespace SimuDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Quacking();
        }

        public void Display()
        {
            Console.WriteLine("I'm a model duck!");
        }
    }
}
