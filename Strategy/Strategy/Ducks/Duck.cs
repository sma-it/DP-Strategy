using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    abstract class Duck
    {
        Behaviors.IQuackBehavior quackBehavior;
        public Behaviors.IQuackBehavior QuackBehavior { set => quackBehavior = value; }

        Behaviors.IFlyBehavior flyBehavior;
        public Behaviors.IFlyBehavior FlyBehavior { set => flyBehavior = value; }

        public void swim()
        {
            Console.WriteLine("swim swim swim");
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public abstract void display();
    }
}
