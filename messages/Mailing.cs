using System;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace messages
{
	public class Mailing : Message
	{
        private int additionalAmount;
        private string[] additionalReceivers;

        public Mailing()
            : base()
        {
            additionalAmount = 0;
            additionalReceivers = new string[] {};
        }

        public Mailing(string sNum, string rNum, string txt, int amount, string[] addRec)
            : base(sNum, rNum, txt)
        {
            additionalAmount = amount;
            additionalReceivers = new string[amount];
            for (int i = 0; i < amount; ++i)
            {
                additionalReceivers[i] = addRec[i];
            }
        }

        public override int calculatePrice()
        {
            return base.calculatePrice() * (additionalAmount + 1);
        }

        public string convertReceivers()
        {
            string conv = "";
            for (int i = 0; i < additionalAmount; ++i)
            {
               conv += additionalReceivers[i] + " ";
            }
            return conv;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nДодаткові отримувачі: {convertReceivers()}";
        }

        public int AdditionalAmount
        {
            get
            {
                return additionalAmount;
            }
            set
            {
                additionalAmount = value > 0 ? value : throw new ArgumentException();
            }
        }

        public string[] AdditionalReceivers
        {
            get
            {
                return additionalReceivers;
            }
            set
            {
                additionalReceivers = value;
            }
        }

        
    }
}