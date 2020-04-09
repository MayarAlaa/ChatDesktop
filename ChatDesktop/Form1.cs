using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatDesktop
{
    public partial class Form1 : Form
    {
        IHubProxy _proxy;
        public Form1()
        {
            InitializeComponent();

            //define the connection
            HubConnection conn = new HubConnection("http://localhost:44332");

            //create proxy
            _proxy = conn.CreateHubProxy("chatHub");

            //start the connection
           conn.Start();



            //Subscribe functions executed at client

            _proxy.On<string, string>("newMessage", (name, msg) => listBox1.Invoke(
                                    new Action(() => listBox1.Items.Add(name + ":" + msg))
                                     ));


             _proxy.On<string, string>("newMember", (name, grpName) => listBox1.Invoke(
                     new Action(() => listBox1.Items.Add(name + " joined group " + grpName))
                     ));

            _proxy.On<string, string,string>("messageGrp", (name, grpName, msg) => listBox1.Invoke(
                     new Action(() => listBox1.Items.Add(name + "(" + grpName + ") : " + msg))
                     ));


        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            //function executed at Hub(server)
            _proxy.Invoke("sendMessage", txtName.Text, txtMsg.Text);
        }

        private void joinBtn_Click(object sender, EventArgs e)
        {
            //function executed at Hub(server)
            _proxy.Invoke("joinGroup", txtName.Text,txtGrp.Text);
        }

        private void grpMsgBtn_Click(object sender, EventArgs e)
        {
            //function executed at Hub(server)
            _proxy.Invoke("sendMsgToGrp", txtName.Text, txtGrp.Text,txtMsg.Text);
        }
    }
}
