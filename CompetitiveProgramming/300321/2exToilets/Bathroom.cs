using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTwo
{
    class Bathroom
    {
        private SmartLock smartLock;
        private string id;

        public Bathroom(SmartLock SmartLock, string ID)
        {
            this.smartLock = SmartLock;
            this.id = ID;
        }

        public void Enter()
        {
            smartLock.Lock();
        }

        public void Leave()
        {
            smartLock.Unlock();
        }

        public bool IsBusy()
        {
            return smartLock.IsItOpen();
        }
    }
}
