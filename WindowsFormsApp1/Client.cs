using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Client
    {
        public int clientValue;

        public bool isDone = false;

        public abstract void Request();
    }
}
