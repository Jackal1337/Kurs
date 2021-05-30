using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class mejdur : Form
    {
        Timer timer = new Timer();
        int sort = 0;
        public mejdur()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bus time = new Bus();
            label4.Text = time.Tine();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.Font = new Font("Microsoft Sans Serif", Convert.ToInt32(textBox1.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sort = 550;
            pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\550.png");
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\550.accdb");
            OleDbCommand command = new OleDbCommand("SELECT [550].*FROM[550]", conn);
            label6.Text = "Новокузнецкий автовокзал — Автовокзал Междуреченск";
            richTextBox1.Clear();
            Bus bus = new Bus();
            List<Bus> buslist = new List<Bus>();
            conn.Open();

            using (conn)
            {

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        buslist.Add(new Bus() { hours = reader.GetInt32(0), minutes = reader.GetInt32(1) });
                    }
                }
            }

            foreach (var Buslist in buslist)
            {
                richTextBox1.Text += Convert.ToString(Buslist) + Environment.NewLine;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sort = 682;
            pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\550.png");
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\682.accdb");
            OleDbCommand command = new OleDbCommand("select  * from 682", conn);
            label6.Text = "Новокузнецкий автовокзал — Автовокзал Междуреченск";
            richTextBox1.Clear();
            Bus bus = new Bus();
            List<Bus> buslist = new List<Bus>();
            conn.Open();
            using (conn)
            {

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        buslist.Add(new Bus() { hours = reader.GetInt32(0), minutes = reader.GetInt32(1) });
                    }
                }
            }

            foreach (var Buslist in buslist)
            {
                richTextBox1.Text += Convert.ToString(Buslist) + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(sort)
            {
                case 550:
                    {
                        pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\550.png");
                        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\550.accdb");
                        OleDbCommand command = new OleDbCommand("SELECT [550].*FROM[550]", conn);
                        label6.Text = "Новокузнецкий автовокзал — Автовокзал Междуреченск";
                        richTextBox1.Clear();
                        List<Sort> buslist = new List<Sort>();
                        conn.Open();

                        using (conn)
                        {

                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    buslist.Add(new Sort() { hours = reader.GetInt32(0), minutes = reader.GetInt32(1) });
                                }
                            }
                        }

                        foreach (var Buslist in buslist)
                        {
                            richTextBox1.Text += Convert.ToString(Buslist) + Environment.NewLine;
                            if (richTextBox1.Text == "\n")
                            {
                                richTextBox1.Clear();
                            }
                        }
                        conn.Close();
                        break;
                    }
                case 682:
                    {
                        pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\550.png");
                        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\682.accdb");
                        OleDbCommand command = new OleDbCommand("select  * from 682", conn);
                        label6.Text = "Новокузнецкий автовокзал — Автовокзал Междуреченск";
                        List<Sort> buslist = new List<Sort>();
                        conn.Open();
                        richTextBox1.Clear();
                        using (conn)
                        {

                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    buslist.Add(new Sort() { hours = reader.GetInt32(0), minutes = reader.GetInt32(1) });
                                }
                            }
                        }

                        foreach (var Buslist in buslist)
                        {
                            richTextBox1.Text += Convert.ToString(Buslist) + Environment.NewLine;
                            if (richTextBox1.Text == "\n")
                            {
                                richTextBox1.Clear();
                            }
                        }
                        conn.Close();
                        break;
                    }
            }
        }
    }
}
