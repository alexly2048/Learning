using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ListAssemblyDemo
{
   public class Program
    {
        static void Main(string[] args)
        {
         //   BuildingAssembly building = new BuildingAssembly();
            string path = @"D:\SearchingCore.dll";
         //   StringCollection collection = new StringCollection();
         //   building.BuildDependecntAssembly(path, collection);
         //   foreach( string name in collection)
         //   {
         //       Console.WriteLine($"\t{name}{Environment.NewLine}");
         //   }


            Assembly asm = Assembly.LoadFrom(path);
            IEnumerable<MemberInfo> members = asm.GetMembersInAssembly("*");
            foreach(MemberInfo info in members)
            {
                Console.WriteLine($"Members in SearchingCore:\t{info.Name}\t{info.DeclaringType}");
            }
            Console.ReadKey();
        }



    }

}
