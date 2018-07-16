using Microsoft.Owin.Hosting;
using System;
using EasyNetQ;

namespace OwinAPI
{
    class Program
    {
        const string url = "http://localhost:9001";
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Chat Sender Started at:" + url);

                var bus = RabbitHutch.CreateBus("host=localhost");
                bus.Subscribe<Message>("someScriptionid", msg => Console.WriteLine(msg.someText));


                Console.ReadLine();
            }
        }
    }
}