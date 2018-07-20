using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingExample
{
     public class ServerClass
    {
        public void InstanceMethod()
        {
            Console.WriteLine(
                "ServerClass.InstanceMethod is running on another thread.");
        }

        public static void StaticMethod()
        {
            Console.WriteLine(
                "ServerClass.StaticMethod is running on another thread .");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ServerClass serverClass = new ServerClass();
            Thread instanceCaller = new Thread(
                new ThreadStart(serverClass.InstanceMethod));
            instanceCaller.Start();
            Console.WriteLine("The Main() thread calls this after "
            + "starting the new InstanceCaller thread.");
            // Create the thread object, passing in the
            // serverObject.StaticMethod method using a
            // ThreadStart delegate.
            Thread StaticCaller = new Thread(
                new ThreadStart(ServerClass.StaticMethod));
            // Start the thread.
            StaticCaller.Start();
            Console.WriteLine("The Main() thread calls this after "
                + "starting the new StaticCaller thread.");
         */

            ThreadWithState tws = new ThreadWithState(
                "This report displays the number {0}.", 42);

            Thread thread = new Thread(new ThreadStart(tws.ThreadProc));
            thread.Start();
            Console.WriteLine("Main thread does some work, then waits.");
            thread.Join();
            Console.WriteLine(
                "Independent task has completed; main thread ends.");
            Console.ReadKey();
        }
    }

    public class ThreadWithState
    {
        private string boilerplate;
        private int number;

        public ThreadWithState(string text,int number)
        {
            boilerplate = text;
            this.number = number;
        }

        public void ThreadProc()
        {
            Console.WriteLine(boilerplate, number);
        }

    }
}
