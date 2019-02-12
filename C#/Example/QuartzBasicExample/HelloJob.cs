using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzBasicExample
{
    public class HelloJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
           Console.WriteLine("Hello Job, now it:\t{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffffff"));
            return null;
        }
    }
}
