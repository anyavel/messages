using System;
using System.Text.Json;

namespace messages
{

    public class Message : IComparable
    {
        protected string senderNumber;
        protected string receiverNumber;
        protected string text;

        public Message() 
        {
            senderNumber = "+380000000000";
            receiverNumber = "+380000000000";
            text = "No text";
        }

        public Message(string sNum, string rNum, string txt)
        {
            senderNumber = sNum;
            receiverNumber = rNum;
            text = txt;
        }

        public virtual int calculatePrice()
        {
            return text.Length / 40 + 1;
        }

        public override string ToString()
        {
            return $"Відправник: {senderNumber}. Отримувач: {receiverNumber}\nПовідомлення: {text}\nВартість: {calculatePrice()} грн.";
        }

        public int CompareTo(object obj)
        {
            Message msg = obj as Message;
            int res = this.text.Length - msg.text.Length;
            if (res == 0)
            {
                return 0;
            }
            else if (res > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static bool operator >(Message first, Message second)
        {
            return first.CompareTo(second) > 0;
        }

        public static bool operator <(Message first, Message second)
        {
            return first.CompareTo(second) < 0;
        }

        public override bool Equals(object obj)
        {
            Message msg = obj as Message;
            return this.senderNumber == msg.senderNumber && this.receiverNumber == msg.receiverNumber && this.text == msg.text;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Message first, Message second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Message first, Message second)
        {
            return !first.Equals(second);
        }

        public static Message operator +(Message msg, string newText)
        {
            return new Message(msg.senderNumber, msg.receiverNumber, msg.text + newText);
        }

        public string SenderNumber
        {
            get
            {
                return senderNumber;
            }
            set
            {
                senderNumber = value.StartsWith("+380") == true && value.Length == 13 ? value : throw new ArgumentException();
            }
        }

        public string ReceiverNumber
        {
            get
            {
                return receiverNumber;
            }
            set
            {
                receiverNumber = value.StartsWith("+380") == true && value.Length == 13 ? value : throw new ArgumentException();
            }
        }

        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value.GetType().ToString() == "System.String" ? value : text;
                calculatePrice();
            }
        }

        public bool IsMailing()
        {
            if (this is Mailing)
            {
                return true;
            }
            return false;
        }

        private static JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        public static List<Message> readMessagesFromFile()
        {
            try
            {
                using FileStream json = File.OpenRead(@"..\..\..\messages.json");
                return JsonSerializer.Deserialize<List<Message>>(json, options);
            }
            catch
            {
                return new List<Message>();
            }
        }

        public async static void WriteMessagesToFile(List<Message> messages)
        {
            await using var fileStream = File.Create(@"..\..\..\messages.json");
            await JsonSerializer.SerializeAsync(fileStream, messages);
        }
    }
}