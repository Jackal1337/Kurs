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

    public partial class PRK : Form
    {
        Timer timer = new Timer();
        int sort = 0;
        public PRK()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bus time = new Bus();
            label4.Text = time.Tine();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //151
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\151List.accdb");
            OleDbCommand command = new OleDbCommand("select  * from 151", conn);
            label6.Text = "Новокузнецкий автовокзал — Прокопьевск Тупик";
            richTextBox1.Clear();
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
            pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\151.png");
            conn.Close();
            sort = 1;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //155
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\155_2List.accdb");
            OleDbCommand command = new OleDbCommand("select  * from 155_2", conn);
            label6.Text = "Новокузнецкий автовокзал — Прокопьевск Дом ветеранов";
            richTextBox1.Clear();
            
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

            pictureBox1.Image = Image.FromFile(@"F:\OpenCV\Kurs\bin\Debug\155.png");
            conn.Close();
            sort = 2;
        }

        private void oleDbDataAdapter1_RowUpdated(object sender, System.Data.OleDb.OleDbRowUpdatedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.Font = new Font("Microsoft Sans Serif", Convert.ToInt32(textBox1.Text));
            }
        }

        private void oleDbConnection1_InfoMessage(object sender, OleDbInfoMessageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (sort)
            {
                case 1:
                    {

                        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\151List.accdb");
                        OleDbCommand command = new OleDbCommand("select  * from 151", conn);
                        label6.Text = "Новокузнецкий автовокзал — Прокопьевск Дом ветеранов";
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
                        break;
                    }

                case 2:
                    {

                        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\OpenCV\Kurs\155_2List.accdb");
                        OleDbCommand command = new OleDbCommand("select  * from 155_2", conn);
                        label6.Text = "Новокузнецкий автовокзал — Прокопьевск Дом ветеранов";
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
