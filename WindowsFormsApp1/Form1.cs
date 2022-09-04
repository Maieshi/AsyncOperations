using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        System.Timers.Timer readerTimer = new System.Timers.Timer();
        System.Timers.Timer writerTimer = new System.Timers.Timer();
        List<Client> clients = new List<Client>();
        public delegate void ReadersDelegate();
        event ReadersDelegate ReadersEvent;
        public Form1()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            timer.Elapsed += Spawn;
            readerTimer.Elapsed += Read;
            readerTimer.Elapsed += Write;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer.Enabled)
            {
                timer.Stop();
                readerTimer.Stop();
                writerTimer.Stop();
            }
            else
            {
                timer.Start();
                readerTimer.Start();
                writerTimer.Start();
            }
        }
        private async void Spawn(Object source, ElapsedEventArgs e)
        {
            lock (clients)
            {
                Random random = new Random();
                Client client;
                if (random.Next(2)!=1)
                {
                    client = new Reader();
                    ReadersEvent += client.Request;
                }
                else
                {
                    client = new Writer();
                    client.clientValue = random.Next(-5, 6);
                }
                clients.Add(client);
                ClientsLog.Items.Add(client + client.clientValue.ToString() + client.isDone);
                ClearAndPrint();
                ClientCount.Text = clients.Count().ToString();
            }
        }

        private void Read(Object source, ElapsedEventArgs e)
        {
            List<Client> activeReaders;
            lock (clients)
            {
                activeReaders = clients.Where(x => x is Reader && ((Reader)x).isDone == false).ToList();
                int readersCount = activeReaders.Count();
                ReadersEvent?.Invoke();
                Get.Text = (Convert.ToInt32(Get.Text) + readersCount).ToString();
            }
        }

        private void Write(Object source, ElapsedEventArgs e)
        {
            List<Writer> writers;
            lock (clients)
            {
                writers= clients.Where(x => x is Writer && x.isDone == false).Select(x => x as Writer).ToList();
                if (writers.Count > 0)
                    writers[writers.Count - 1].Request();
                Set.Text = (Convert.ToInt32(Set.Text) + 1).ToString();
                ServerValueLog.Items.Add(Server.GetCount());
            }
        }


        private void ClearAndPrint()
        {
            lock(clients)
            { 
                foreach(var client in clients)
                {
                    if(client.isDone && client is Reader)
                        ReadersEvent -= client.Request;
                }
                clients.RemoveAll(x => x.isDone);
                ActiveClients.Items.Clear();
                clients.Reverse();
                foreach(var client in clients)
                {
                    ActiveClients.Items.Add(client + client.clientValue.ToString() + client.isDone);
                }
                clients.Reverse();
            }
        }

        private void AsyncCaller_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
