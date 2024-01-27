using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.AspNet.SignalR.Client;

namespace WFConsumer
{
    public partial class Form1 : Form
    {

        IHubProxy prox;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HubConnection connection = new HubConnection("http://localhost:59407/");
            prox = connection.CreateHubProxy("chat");
            connection.Start();

            // Working
            //prox.On<Data>("newMessage", (Message) => 
            //          lb_mess.Items.Add(Message.name + ": " + Message.message1));

            prox.On<Data>("newMessage", (Message) =>
                      lb_mess.Invoke(new Action(() => 
                           lb_mess.Items.Add(Message.name + ": " + Message.message1))));

            prox.On<string, string>("newMember", (name, gname) => 
                       lb_mess.Invoke(new Action(() => 
                                 lb_mess.Items.Add(name + " joined " + gname))));

            prox.On<string, string, string>("groupmsg", (name, gname, message) =>
                     lb_mess.Invoke(new Action(() =>
                             lb_mess.Items.Add(name + "(" + gname + "): " + message))));

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            prox.Invoke("sendMessage", new Data() 
                           { name = txt_name.Text, message1 = txt_message.Text });
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            prox.Invoke("joinGroup", txt_group.Text, txt_name.Text);
        }

        private void btn_sendgroup_Click(object sender, EventArgs e)
        {
            prox.Invoke("sendToGroup", txt_group.Text, txt_name.Text, txt_message.Text);
        }
    }
}
