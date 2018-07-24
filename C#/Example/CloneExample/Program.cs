using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // test ShallowClone and DeepClone()

            PeopleInfo peopleInfo = new PeopleInfo();
            peopleInfo.Name = "Felix";
            peopleInfo.Age = 25;

            PeopleInfo shallowClonePeople = peopleInfo.ShallowClone();
            PeopleInfo deepClonePeople = peopleInfo.DeepClone();
            Console.WriteLine($"Name: {shallowClonePeople.Name}, Age: {shallowClonePeople.Age}");
            Console.WriteLine($"Name: {deepClonePeople.Name}, Age: {deepClonePeople.Age}");
            Console.ReadKey();
        }
    }
}
