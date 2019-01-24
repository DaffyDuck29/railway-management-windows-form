using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation
{
    public partial class trtiming : UserControl
    {
        public trtiming()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trpanel.Height = button1.Height;
            tezgam1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trpanel.Height = button2.Height;
            hazara1.BringToFront();
        }

        private void hazara1_Load(object sender, EventArgs e)
        {

        }

        private void trpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            trpanel.Height = button4.Height;
            millat1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            trpanel.Height = button3.Height;
            awami1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            trpanel.Height = button8.Height;
            allamaiqbal1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            trpanel.Height = button7.Height;
            bussiness1.BringToFront();
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trpanel.Height = button6.Height;
            sukkur1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trpanel.Height = button5.Height;
            fareed1.BringToFront();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            trpanel.Height = button10.Height;
            zikria1.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            trpanel.Height = button9.Height;
            pakistan1.BringToFront();
        }
    }
}
