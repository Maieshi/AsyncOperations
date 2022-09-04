using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public EventHandler myEventHandler= new EventHandler(Swap);

        Arguments args = new Arguments() { I=1, i = 19 };

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            EventHandler h = new EventHandler(this.myEventHandler);
            AsyncCaller ac = new AsyncCaller(h);
            bool completedOK = ac.Invoke(5000, this, args);
            listBox1.Items.Add(completedOK);
        }

        public static void Swap(object sender, EventArgs e)
        {
            Arguments args = e as Arguments;
            (args.I, args.i) = (args.i, args.I);
        }
    }
}
