using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTwo
{
    class Person
    {
        private string name;
        private int age;

        public void GoToToilet(Bathroom ID)
        {
            ID.Enter();
        }

        public void LeaveToilet(Bathroom ID)
        {
            ID.Leave();
        }
    }
}
