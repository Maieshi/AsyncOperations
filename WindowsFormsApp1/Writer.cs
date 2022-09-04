using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Writer:Client
    {
        public override void Request()
        {
            Server.AddCount(clientValue);
            isDone = true;
        }
    }
}
