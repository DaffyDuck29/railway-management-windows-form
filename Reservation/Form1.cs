using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            slidepanel.Height = button1.Height;
            mgl1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button1.Height;
           mgl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button2.Height;
            reservation2.BringToFront();
            

        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button3.Height;
            driver1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            slidepanel.Height = button6.Height;
            trtiming1.BringToFront();
        }

        private void trtiming1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
