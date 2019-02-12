using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MessageQueueExample
{
    public class Order
    {
        public int orderId;
        public DateTime orderTime;
    }
    public class MyNewQueue
    {
        static void Main(string[] args)
        {
            MyNewQueue myNewQueue = new MyNewQueue();
            myNewQueue.SendMessage();
            myNewQueue.ReceiveMessage();
            return;
        }

        public void SendMessage()
        {
            Order sendOrder = new Order();
            sendOrder.orderId = 1;
            sendOrder.orderTime = DateTime.Now;
            // Connect to a queue on the local computer.
            MessageQueue myQueue = new MessageQueue(".\\myQueue");
            myQueue.Send(sendOrder);
            return;
        }

        public void ReceiveMessage()
        {
            MessageQueue myQueue = new MessageQueue(".\\myQueue");
            myQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(MessageQueueExample.Order) });
            try
            {
                Message myMessage = myQueue.Receive();
                Order myOrder = (Order)myMessage.Body;
                // Display message information.
                Console.WriteLine("Order ID:" +
                    myOrder.orderId.ToString());
                Console.WriteLine("Send: " +
                    myOrder.orderTime.ToString());
            }
            catch (MessageQueueException)
            {

            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            return;
        }
    }
}
