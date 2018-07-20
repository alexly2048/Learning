using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadCallBackExample
{
    public class ThreadWithCallBack
    {
        private string input = string.Empty;
        private int number = 0;
        // Delegate used to execute the callback method
        public delegate void ExampleCallback(int lineCount);
        private ExampleCallback callback;

        public ThreadWithCallBack(string text, int num, ExampleCallback callBackDelegate)
        {
            input = text;
            number = num;
            callback = callBackDelegate;
        }

        public void ThreadProc()
        {
            Console.WriteLine(input, number);
            if (callback != null)
                callback(1);
        }
    }
}
