using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertNumToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            Int16 num1 = 32;
            byte byte0 = Convert.ToByte(Convert.ToString(num1,16));
            Console.WriteLine("Integer 32 convert to Hex is : {0}", byte0.ToString());
            Console.WriteLine(Math.Pow(2, 16));
            Console.ReadLine();
        }
    }
}
