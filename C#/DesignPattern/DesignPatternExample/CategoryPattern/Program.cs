using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CategoryPattern.Category;

namespace CategoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck modelDuck = new ModelDuck();
            FlyBehavior flyBehavior = new FlyNoWay();
            modelDuck.FlyBehavior = flyBehavior;
            modelDuck.Fly();
            Console.ReadKey();
        }
    }
}
