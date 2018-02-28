using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace SendSMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
            SmtpClient smtp = new SmtpClient();
            MailMessage message = new MailMessage();
            smtp.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
            smtp.Host = "ipipi.com";
            message.From = new MailAddress(string.Format("{0}@ipipi.com", txtUser.Text));
            message.To.Add(string.Format("{0}@sms.ipipi.com", txtTo.Text));
            message.Subject = "Test Send Message.";
            message.Body = rtxtMessage.Text;
            smtp.Send(message);
            MessageBox.Show("Sent Successfully.");

            }
            catch (Exception) { MessageBox.Show("Error"); }
            
            //*******************************

            //for send mail 
            //**
            //using System.Net.Mail;


            string fromaddr = "kinanshasho@gmail.com";
            string toaddr = "Address";//TO ADDRESS HERE
            string password = "Password";


            MailMessage msg = new MailMessage();
            msg.Subject = "Username &password";
            msg.From = new MailAddress(fromaddr);
            msg.Body = "Message BODY";
            msg.To.Add(new MailAddress(toaddr));
            SmtpClient smtp1 = new SmtpClient();
            smtp1.Host = "smtp.gmail.com";
            smtp1.Port = 587;
            smtp1.UseDefaultCredentials = false;
            smtp1.EnableSsl = true;
            NetworkCredential nc = new NetworkCredential(fromaddr, password);
            smtp1.Credentials = nc;
            smtp1.Send(msg);
        }
    }
}
