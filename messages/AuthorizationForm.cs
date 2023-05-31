using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace messages
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            bool valid = true;
            List<Message> msgs = Message.readMessagesFromFile();
            string phoneNumber = PhoneNumberInput.Text;
            if (phoneNumber == null || !phoneNumber.StartsWith("+380") || phoneNumber.Length != 13)
            {
                valid = false;
            }
            if (valid)
            {
                Program.mainForm.LogInHandle(this, new LogInClickHandle() { Messages = msgs, PhoneNumber = PhoneNumberInput.Text });
                this.Close();
                Program.mainForm.Show();

            }
            else
            {
                MessageBox.Show("Неправильний формат номера!\nПеревірте кількість цифр або спробуйте почати введення з +380", "Помилка");
            }

        }
    }
}
