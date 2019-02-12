using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryPattern.Category
{
    public abstract class Duck
    {
        protected string name;
      protected  FlyBehavior flyBehavior;
      protected  QuackBehavior quackBehavior;
        public string Name { get; set; }

        public void Fly()
        {
            flyBehavior.Fly();
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }

       public  FlyBehavior FlyBehavior { get =>flyBehavior; set => flyBehavior = value; }

        public QuackBehavior QuackBehavior { get => quackBehavior; set => quackBehavior = value; }
    }
}
