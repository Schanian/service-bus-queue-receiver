using System;
using Microsoft.Azure.ServiceBus;

namespace subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Microsoft.Azure.ServiceBus.QueueClient queueClient = new QueueClient("Endpoint=sb://singheveloper-azure.servicebus.windows.net/;SharedAccessKeyName=testQueueMng;SharedAccessKey=ASUse6UlF71pw9LZCOfAcuexfq+pwfiVpvfQPcxzNvk=;","testqueue");
            queueClient.RegisterMessageHandler(
                    async (msg,cancelationToken) => {
                            var body = System.Text.Encoding.UTF8.GetString(msg.Body);
                            Console.WriteLine(body);
            },async exception => {
                Console.WriteLine("Error ");
            });

            Console.ReadKey();
        }
    }
}
