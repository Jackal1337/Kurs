using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class Form1 : Form
    {
    
        
       
       
        
        
        Timer timer = new Timer();

        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PRK prk = new PRK();
            prk.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Osinniki osinniki = new Osinniki();
            osinniki.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Leninsk leninsk = new Leninsk();
            leninsk.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mejdur Mejd = new mejdur();
            Mejd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kemerovo kemerovo = new Kemerovo();
            kemerovo.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Novosibirsk novosibirsk = new Novosibirsk();
            novosibirsk.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Tomsk tomsk = new Tomsk();
            tomsk.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bus time = new Bus();
            label3.Text = time.Tine();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
