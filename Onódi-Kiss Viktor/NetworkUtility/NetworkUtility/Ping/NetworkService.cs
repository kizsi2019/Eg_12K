﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {
            return "Success: Pinge sent!";
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }

        public string Teljes(int a)
        {
            if(a < 0)
            {
                return "Negatív";
            }
            else if(0 == a)
            {
                return "Nulla";
            }
            else
            {
                return "Pozitív";
            }
        }
    }
}
