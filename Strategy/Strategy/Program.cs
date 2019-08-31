using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Ducks.Duck duck = new Ducks.MallardDuck();
                duck.display();
                duck.swim();
                duck.performQuack();
                duck.performFly();
            }
            Console.WriteLine();
            {
                Ducks.Duck duck = new Ducks.RedheadDuck();
                duck.display();
                duck.swim();
                duck.performQuack();
                duck.performFly();
            }
            Console.WriteLine();
            {
                Ducks.Duck duck = new Ducks.RubberDuck();
                duck.display();
                duck.performQuack();
                duck.performFly();

                // if we try to make the rubber duck fly, there will be an 
                // error. Which is good, because rubber ducks cannot fly.
            }
            Console.WriteLine();
            {
                Ducks.Duck duck = new Ducks.DecoyDuck();
                duck.display();
                duck.performQuack();
                duck.performFly();
                duck.FlyBehavior = new Ducks.Behaviors.FlyWithRocket();
                duck.performFly();
            }

            Console.ReadKey();
        }
    }
}
