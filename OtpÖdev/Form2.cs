using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace OtpÖdev
{

    public partial class Form2 : Form
    {
        private string senderEmail = "sampleMail@mail.com";
        private string senderPass = "xxxxxx";
        private int otp;
        private string Email;
        DateTime dt = DateTime.Now.AddMinutes(3);
        public void setEmail(string Email)
        {
            this.Email = Email;
        }
        public string getEmail()
        {
            return Email;
        }

        public Form2()
        {
            Form1 frm1 = new Form1();
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == otp.ToString())
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                MessageBox.Show("Giriş Yapılamadı");
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            otp = random.Next(100000, 999999);
            label2.Text = dt.ToString();
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.office365.com".Trim();
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(senderEmail.Trim(), senderPass.Trim());
            MailMessage mailDetail = new MailMessage();
            mailDetail.From = new MailAddress(senderEmail.Trim());
            mailDetail.To.Add(getEmail());
            mailDetail.Subject = "Mail Doğrulama";
            mailDetail.IsBodyHtml = true;
            mailDetail.Body = otp.ToString();
            client.Send(mailDetail);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

