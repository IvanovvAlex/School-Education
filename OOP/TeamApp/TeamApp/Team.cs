using System;
using System.Collections.Generic;
using System.Text;

namespace TeamApp
{
    public class Team
    {
        public string firstName;
        public string secondName;
        public int age;
        public Team(string firstName, string secondName, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
        }
    }
}
