using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Behaviors.Squeak();
            FlyBehavior = new Behaviors.FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("I am a rubber duck");
        }
    }
}
