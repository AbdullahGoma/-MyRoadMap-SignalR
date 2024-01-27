using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FirstDemo.Models;
using System.Threading.Tasks;

namespace FirstDemo
{
    [HubName("chat")]
    // Our Services Do Broad Casting
    public class ChatHub : Hub
    {
        //public void sendMessage(string name, string message)
        public void sendMessage(Messages messages)
        {
            // Callback Method
            Clients.All.newMessage(messages); // Go to Clients who subscribe newMessage =>
                                                   // Data and execute it by protocol called
                                                   // Remote Procedure Calling"RPC"

            //Clients.Others.newMessage(name, message);

            // Save in Data Base
            ChatContext context = new ChatContext();

            //Messages messages = new Messages()
            //{
            //    name = name,
            //    message1 = message,
            //    date = DateTime.Now
            //};
            messages.date = DateTime.Now;
            context.Messages.Add(messages);
            context.SaveChanges();



            //try {
            //    ChatContext context = new ChatContext();
            //    Messages messages = new Messages()
            //    {
            //        name = name,
            //        message1 = message,
            //        date = DateTime.Now
            //    };
            //    context.Messages.Add(messages);
            //    context.SaveChanges();
            //}catch 
            //{
            //    Clients.All.removeMessage(message); // RPC
            //}

        }

        public void joinGroup(string gname, string name)
        {
            Groups.Add(Context.ConnectionId, gname);
            Clients.OthersInGroup(gname).newMember(name, gname);

        }

        public void sendToGroup(string gname, string name, string message)
        {
            Clients.Group(gname).groupmsg(name , gname, message);

            // Save Db
        }

        public override Task OnConnected()
        {

            return base.OnConnected();
        }

    }
}
