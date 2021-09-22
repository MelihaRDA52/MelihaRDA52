using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private object matematıkNet;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, matematıkDogru;
            double turkceYanlis, matematıkYanlis;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(textBox1.Text);
            turkceYanlis = Convert.ToDouble(textBox2.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));
            textBox3.Text = turkceNet.ToString();
            matematıkDogru = Convert.ToDouble(textBox4.Text);
            matematıkYanlis = Convert.ToDouble(textBox5.Text);
            matematıkNet= (matematıkDogru - (matematıkYanlis / 4));
            textBox6.Text = matematıkNet.ToString();
        }
    }
}
