using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
namespace WindowsFormsApp1
{
        public static class Server
        {
            private static int _count;

            private static ReaderWriterLockSlim _countLock = new ReaderWriterLockSlim();

            public static int GetCount()
            {
                _countLock.EnterReadLock();
                try
                {
                    return _count;
                }
                finally
                {
                    _countLock.ExitReadLock();
                }
            }

            public static void AddCount(int value)
            {
                _countLock.EnterWriteLock();
                try
                {
                    checked
                    {
                        _count += value;
                    }
                }
                finally
                {
                    _countLock.ExitWriteLock();
                }
            }
        }
}
