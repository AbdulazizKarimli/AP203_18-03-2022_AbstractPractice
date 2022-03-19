using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPractice
{
    internal class SmsSender:MessageSender
    {
        public override void SendMessage()
        {
            Console.WriteLine("SmsSender Class");
        }
    }
}
