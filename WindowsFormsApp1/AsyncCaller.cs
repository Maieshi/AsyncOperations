using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AsyncCaller
    {
        private EventHandler _handler;

        public AsyncCaller(EventHandler handler)
        {
            _handler = handler;
        }

        public bool Invoke(int milliseconds, object sender, EventArgs args)
        {
            var task = Task.Factory.StartNew(() => _handler.Invoke(sender, args));

            return task.Wait(milliseconds);
        }
    }
}
