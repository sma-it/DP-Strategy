using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new Behaviors.MuteQuack();
            FlyBehavior = new Behaviors.FlyNoWay();
        }

        public override void display()
        {
            Console.WriteLine("I want to be a real duck");
        }
    }
}
