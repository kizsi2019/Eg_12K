﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace networkutility.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {
            return "Succes:Ping sent!";
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public string Teljes(int a)
        {
            if (a < 0)
            {
                return ("Negativ");
            }
            else if (a == 0)
            {
                return ("Zero");
            }
            else
            {
                return ("Positiv");
            }

        }

        public DateTime
            {

}
    }
}
