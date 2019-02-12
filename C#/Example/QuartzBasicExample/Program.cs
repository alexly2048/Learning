using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartzBasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            QuartzBasic();
            Console.ReadKey();
        }

        static  async void QuartzBasic()
        {
            // Construct a scheduler factory
            NameValueCollection props = new NameValueCollection
            {
                {"quartz.serializer.type","binary" }
            };
            StdSchedulerFactory factory = new StdSchedulerFactory(props);

            // get a scheduler
            IScheduler sched = await factory.GetScheduler();
            await sched.Start();

            // define the job and tie it ot our HelloJob class
            IJobDetail job = JobBuilder.Create<HelloJob>()
                   .WithIdentity("myJob", "group1")
                   .Build();

            // Trigger the job to run now, and every 40 seconds
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("myTrigger", "group1")
                .StartNow()
                .WithSimpleSchedule(x =>x
                    .WithIntervalInSeconds(10)
                    .RepeatForever())
                .Build();
            await sched.ScheduleJob(job, trigger);
        }

    }
}
