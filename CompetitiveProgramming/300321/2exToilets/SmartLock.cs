using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTwo
{
    class SmartLock
    {
        private bool isLocked;

        public bool IsItOpen()
        {
            if (isLocked == true)
            {
                Console.WriteLine("Toilet is not available.");
                isLocked = true;
                return isLocked;
            }
            else
            {
                Console.WriteLine("Toilet is available.");
                isLocked = false;
                return isLocked;
            }
        }

        public bool Lock()
        {
            isLocked = true;
            return isLocked;
        }

        public bool Unlock()
        {
            isLocked = false;
            return isLocked;
        }
    }
}
