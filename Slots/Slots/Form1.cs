using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace Slots
{
    public partial class Form1 : Form
    {
        Randomizar slot1;
        Randomizar slot2;
        Randomizar slot3;

        Thread slot1_c;
        Thread slot2_c;
        Thread slot3_c;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //iniciar y poner las imagenes en nuestro form
            slot1 = new Randomizar(CreateGraphics(), 80, 160);
            slot1_c = new Thread(slot1.girar);
            slot1_c.Start();
            Thread.Sleep(50);
            slot2 = new Randomizar(CreateGraphics(), 350, 160);
            slot2_c = new Thread(slot2.girar);
            slot2_c.Start();
            Thread.Sleep(50);
            slot3 = new Randomizar(CreateGraphics(),600, 160);
            slot3_c = new Thread(slot3.girar);
            slot3_c.Start();
            Thread.Sleep(2000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
