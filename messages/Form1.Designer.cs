﻿namespace messages
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            mailingCheckBox = new CheckBox();
            additionalReceiversLabel = new Label();
            senderTextBox = new TextBox();
            receiverTextBox = new TextBox();
            additionalReceiversTextBox = new TextBox();
            additionalAmountLabel = new Label();
            additionalAmountTextBox = new TextBox();
            messageTextBox = new TextBox();
            label5 = new Label();
            sendButton = new Button();
            cancelButton = new Button();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            sendingLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 20);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Відправник :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 20);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Отримувач :";
            // 
            // mailingCheckBox
            // 
            mailingCheckBox.AutoSize = true;
            mailingCheckBox.Location = new Point(622, 65);
            mailingCheckBox.Name = "mailingCheckBox";
            mailingCheckBox.Size = new Size(118, 24);
            mailingCheckBox.TabIndex = 2;
            mailingCheckBox.Text = "Це розсилка";
            mailingCheckBox.UseVisualStyleBackColor = true;
            mailingCheckBox.CheckedChanged += mailingCheckBox_CheckedChanged;
            // 
            // additionalReceiversLabel
            // 
            additionalReceiversLabel.AutoSize = true;
            additionalReceiversLabel.Location = new Point(372, 171);
            additionalReceiversLabel.Name = "additionalReceiversLabel";
            additionalReceiversLabel.Size = new Size(323, 20);
            additionalReceiversLabel.TabIndex = 3;
            additionalReceiversLabel.Text = "Введіть додаткових отримувачів через кому :";
            additionalReceiversLabel.Visible = false;
            // 
            // senderTextBox
            // 
            senderTextBox.Location = new Point(147, 16);
            senderTextBox.Name = "senderTextBox";
            senderTextBox.Size = new Size(216, 27);
            senderTextBox.TabIndex = 4;
            // 
            // receiverTextBox
            // 
            receiverTextBox.Location = new Point(532, 17);
            receiverTextBox.Name = "receiverTextBox";
            receiverTextBox.Size = new Size(208, 27);
            receiverTextBox.TabIndex = 5;
            // 
            // additionalReceiversTextBox
            // 
            additionalReceiversTextBox.Location = new Point(372, 206);
            additionalReceiversTextBox.Multiline = true;
            additionalReceiversTextBox.Name = "additionalReceiversTextBox";
            additionalReceiversTextBox.Size = new Size(397, 45);
            additionalReceiversTextBox.TabIndex = 6;
            additionalReceiversTextBox.Visible = false;
            // 
            // additionalAmountLabel
            // 
            additionalAmountLabel.AutoSize = true;
            additionalAmountLabel.Location = new Point(372, 124);
            additionalAmountLabel.Name = "additionalAmountLabel";
            additionalAmountLabel.Size = new Size(304, 20);
            additionalAmountLabel.TabIndex = 7;
            additionalAmountLabel.Text = "Введіть кількість додаткових отримувачів :";
            additionalAmountLabel.Visible = false;
            // 
            // additionalAmountTextBox
            // 
            additionalAmountTextBox.Location = new Point(682, 121);
            additionalAmountTextBox.Name = "additionalAmountTextBox";
            additionalAmountTextBox.Size = new Size(48, 27);
            additionalAmountTextBox.TabIndex = 8;
            additionalAmountTextBox.Visible = false;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(27, 102);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(282, 304);
            messageTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 66);
            label5.Name = "label5";
            label5.Size = new Size(156, 20);
            label5.TabIndex = 10;
            label5.Text = "Текст повідомлення :";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(372, 377);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(94, 29);
            sendButton.TabIndex = 11;
            sendButton.Text = "Надіслати";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += send_button_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(676, 377);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Закрити";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(372, 308);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(343, 27);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 13;
            progressBar1.Visible = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // sendingLabel
            // 
            sendingLabel.AutoSize = true;
            sendingLabel.Location = new Point(372, 276);
            sendingLabel.Name = "sendingLabel";
            sendingLabel.Size = new Size(103, 20);
            sendingLabel.TabIndex = 14;
            sendingLabel.Text = "Надсилання...";
            sendingLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 442);
            Controls.Add(sendingLabel);
            Controls.Add(progressBar1);
            Controls.Add(cancelButton);
            Controls.Add(sendButton);
            Controls.Add(label5);
            Controls.Add(messageTextBox);
            Controls.Add(additionalAmountTextBox);
            Controls.Add(additionalAmountLabel);
            Controls.Add(additionalReceiversTextBox);
            Controls.Add(receiverTextBox);
            Controls.Add(senderTextBox);
            Controls.Add(additionalReceiversLabel);
            Controls.Add(mailingCheckBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Повідомлення";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckBox mailingCheckBox;
        private Label additionalReceiversLabel;
        private TextBox senderTextBox;
        private TextBox receiverTextBox;
        private TextBox additionalReceiversTextBox;
        private Label additionalAmountLabel;
        private TextBox additionalAmountTextBox;
        private TextBox messageTextBox;
        private Label label5;
        private Button sendButton;
        private Button cancelButton;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label sendingLabel;
    }
}