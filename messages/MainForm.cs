
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;

namespace messages
{
    public partial class MainForm : Form
    {
        Message message;
        Mailing mailing;

        public MainForm()
        {
            InitializeComponent();
            message = new Message();
            mailing = new Mailing();
            progressBar1.Maximum = 100;
        }

        private void mailingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            additionalAmountLabel.Visible = false;
            additionalAmountTextBox.Visible = false;
            additionalReceiversLabel.Visible = false;
            additionalReceiversTextBox.Visible = false;

            if (mailingCheckBox.Checked == true)
            {
                additionalAmountLabel.Visible = true;
                additionalAmountTextBox.Visible = true;
                additionalReceiversLabel.Visible = true;
                additionalReceiversTextBox.Visible = true;
            }

        }

        private void send_button_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (mailingCheckBox.Checked == false)
            {
                try
                {
                    message.SenderNumber = senderTextBox.Text;
                    message.ReceiverNumber = receiverTextBox.Text;
                }
                catch
                {
                    MessageBox.Show("Неправильний формат номера!\nПеревірте кількість цифр або спробуйте почати введення з +380", "Помилка");
                    check = false;
                }
                message.Text = messageTextBox.Text;
            }

            else if (mailingCheckBox.Checked == true)
            {
                try
                {
                    mailing.SenderNumber = senderTextBox.Text;
                    mailing.ReceiverNumber = receiverTextBox.Text;
                }
                catch
                {
                    MessageBox.Show("Неправильний формат номера!\nПеревірте кількість цифр або спробуйте почати введення з +380", "Помилка");
                    check = false;
                }
                mailing.Text = messageTextBox.Text;
                int n = Convert.ToInt32(additionalAmountTextBox.Text);
                try
                {
                    mailing.AdditionalAmount = n;
                }
                catch
                {
                    MessageBox.Show("Кількість повинна бути цілим додатнім числом", "Помилка");
                    check = false;
                }
                string[] arr = new string[n];
                for (int i = 0; i < n; i++)
                {
                    if (additionalReceiversTextBox.Text.Split(",")[i].StartsWith("+380") == true && senderTextBox.Text.Length == 13)
                        arr[i] = additionalReceiversTextBox.Text.Split(",")[i];
                    else
                    {
                        MessageBox.Show("Неправильний формат номера!\nПеревірте кількість цифр або спробуйте почати введення з +380", "Помилка");
                        check = false;
                    }
                }
                mailing.AdditionalReceivers = arr;
            }

            progressBar1.Visible = false;
            timer1.Enabled = false;

            if (check == true)
            {
                progressBar1.Visible = true;
                timer1.Enabled = true;
            }


            //senderTextBox.Clear();
            //receiverTextBox.Clear();
            //messageTextBox.Clear();
            //additionalAmountTextBox.Clear();
            //additionalReceiversTextBox.Clear();

            //TextWriter textWriter = new StreamWriter("C:\\Users\\ASUS\\Source\\Repos\\messages\\messages\\history.txt");
            //textWriter.Write("Відправник: " + senderTextBox.Text + ". Повідомлення: " + messageTextBox.Text);
            //textWriter.Close();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                Task.Delay(1).ContinueWith(_ =>
                {
                    progressBar1.Invoke((MethodInvoker)(() =>
                    {
                        progressBar1.Visible = false;
                        timer1.Enabled = false;
                        progressBar1.Value = 0;
                        sendingLabel.Visible = false;

                    }));
                });
                if (mailingCheckBox.Checked == false)
                {
                    MessageBox.Show(message.ToString(), "Ваше повідомлення");
                }
                else
                    MessageBox.Show(mailing.ToString(), "Ваше повідомлення");
            }
            else
            {
                progressBar1.Invoke((MethodInvoker)(() =>
                {
                    progressBar1.Increment(10);
                    progressBar1.Visible = true;
                    timer1.Enabled = true;
                    sendingLabel.Visible = true;
                }));
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}