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
    public partial class Kemerovo : Form
    {
        Timer timer = new Timer();
        int sort = 0;
        public Kemerovo()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void Kemerovo_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bus time = new Bus();
            label4.Text = time.Tine();
        }

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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

        }

        private void button9_Click(object sender, EventArgs e)
        {
            sort = 658;
            pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\658.png");
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\Kemerovo.accdb");
            OleDbCommand command = new OleDbCommand("SELECT[658].*FROM[658]", conn);
            label6.Text = "Новокузнецкий автовокзал — Кемеровский автовокзал";
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

        private void button3_Click(object sender, EventArgs e)
        {
            sort = 530;
            pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\530.png");
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\Kemerovo.accdb");
            OleDbCommand command = new OleDbCommand("SELECT[530].*FROM[530]", conn);
            label6.Text = "Новокузнецкий автовокзал — Кемеровский автовокзал";
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
            sort = 692;
            pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\692.png");
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\Kemerovo.accdb");
            OleDbCommand command = new OleDbCommand("SELECT[692].*FROM[692]", conn);
            label6.Text = "Новокузнецкий автовокзал — Кемеровский автовокзал";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            sort = 5302;
            pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\530.png");
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\Kemerovo.accdb");
            OleDbCommand command = new OleDbCommand("SELECT[530п].*FROM[530п]", conn);
            label6.Text = "Новокузнецкий автовокзал — Кемеровский автовокзал";
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
            switch(sort)
            {
                case 658:
                    {
                        pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\658.png");
                        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\Kemerovo.accdb");
                        OleDbCommand command = new OleDbCommand("SELECT[658].*FROM[658]", conn);
                        label6.Text = "Новокузнецкий автовокзал — Кемеровский автовокзал";
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
                case 530:
                    {
                        pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\530.png");
                        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\Kemerovo.accdb");
                        OleDbCommand command = new OleDbCommand("SELECT[530].*FROM[530]", conn);
                        label6.Text = "Новокузнецкий автовокзал — Кемеровский автовокзал";
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
                case 692:
                    {
                        pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\692.png");
                        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\Kemerovo.accdb");
                        OleDbCommand command = new OleDbCommand("SELECT[692].*FROM[692]", conn);
                        label6.Text = "Новокузнецкий автовокзал — Кемеровский автовокзал";
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
                case 5302:
                    {
                        pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\530.png");
                        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\Kemerovo.accdb");
                        OleDbCommand command = new OleDbCommand("SELECT[530п].*FROM[530п]", conn);
                        label6.Text = "Новокузнецкий автовокзал — Кемеровский автовокзал";
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
            }
        }
    }
}
