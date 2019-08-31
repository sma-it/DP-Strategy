using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks.Behaviors
{
    interface IQuackBehavior
    {
        void quack();
    }

    class Quack: IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak!");
        }
    }

    class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("...");
        }
    }
}
