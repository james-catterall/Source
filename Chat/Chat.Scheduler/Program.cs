using Microsoft.Owin.Hosting;
using System;
using System.Security.Cryptography.X509Certificates;
using EasyNetQ;

namespace OwinAPI
{
    class Program
    {
        const string url = "http://localhost:9000";
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Scheduler started at:" + url);

                


                Console.ReadLine();
            }
        }
    }

    public class Message
    {
        public string someText{ get; set; }

        public Message()
        {
            someText = "somneValue";
        }
    }
}