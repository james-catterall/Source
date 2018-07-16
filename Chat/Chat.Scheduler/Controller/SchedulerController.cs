using System.Collections.Generic;
using System.Web.Http;
using EasyNetQ;

namespace OwinAPI.Controller
{
    public class SchedulerController : ApiController
    {
        private readonly IBus bus;

        public SchedulerController()
        {
            bus = RabbitHutch.CreateBus("host=localhost");
        }

        public IEnumerable<string> GetTest()
        {
            return new string[] { "One", "Two", "Three" };
        }

        public void SendMessage()
        {
            var message = new Message();
            bus.Publish(message);
        }
    }
}