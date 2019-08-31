using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            QuackBehavior = new Behaviors.Quack();
            FlyBehavior = new Behaviors.FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I am a readhead");
        }
    }
}
