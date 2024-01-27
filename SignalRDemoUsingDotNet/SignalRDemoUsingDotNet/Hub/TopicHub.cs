using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRDemoUsingDotNet
{

    [HubName("topic")]
    public class TopicHub : Hub
    {
        public void create(topic topic)
        {
            AppDbContext context = new AppDbContext();
            context.topic.Add(topic);
            context.SaveChanges();

            Clients.All.newtopic(topic);
        }
    }
}