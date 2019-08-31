using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks.Behaviors
{
    interface IFlyBehavior
    {
        void fly();
    }

    class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying, with my wings.");
        }
    }

    class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("There is no way I can fly.");
        }
    }

    class FlyWithRocket : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I am flying on a rocket!");
        }
    }
}
