using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TimerTaskExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 6000;
            timer.Start();
            timer.Elapsed += new ElapsedEventHandler(TimerTaskTest);

            Console.ReadKey();
        }

        static void TimerTaskTest(object sender,ElapsedEventArgs e)
        {
            Console.WriteLine("Now datetime is:\t{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));
        }
    }
}
