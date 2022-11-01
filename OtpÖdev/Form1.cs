using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtpÖdev
{
    public partial class Form1 : Form
    {
        string email = "sample@gmail.com";
        string pass = "123qwe";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            if(txtEposta.Text == email && txtParola.Text == pass)
            {
                Form2 frm2 = new Form2();
                frm2.setEmail(email);
                frm2.Show();
            }
        }
    }
}
