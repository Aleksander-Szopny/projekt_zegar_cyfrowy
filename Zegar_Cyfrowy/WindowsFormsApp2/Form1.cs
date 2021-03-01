using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DateTime aktualny;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();

        }
        
        private void change( int index, int index2, int index3)
        {
            List<Bitmap> cyfra = new List<Bitmap>();
            cyfra.Add(Properties.Resources._0);
            cyfra.Add(Properties.Resources._1);
            cyfra.Add(Properties.Resources._2);
            cyfra.Add(Properties.Resources._3);
            cyfra.Add(Properties.Resources._4);
            cyfra.Add(Properties.Resources._5);
            cyfra.Add(Properties.Resources._6);
            cyfra.Add(Properties.Resources._7);
            cyfra.Add(Properties.Resources._8);
            cyfra.Add(Properties.Resources._9);
            index = index % cyfra.Count;
            index2 = index2 % cyfra.Count;
            index3 = index3 % cyfra.Count;
            pictureBox6.Image = cyfra[index];
            pictureBox3.Image = cyfra[index2];
            pictureBox4.Image = cyfra[index3];

        }
        private void change2(int index, int index2, int index3)
        {
            List<Bitmap> cyfra = new List<Bitmap>();
            cyfra.Add(Properties.Resources._0);
            cyfra.Add(Properties.Resources._1);
            cyfra.Add(Properties.Resources._2);
            cyfra.Add(Properties.Resources._3);
            cyfra.Add(Properties.Resources._4);
            cyfra.Add(Properties.Resources._5);
            
            index =  ((index % 100)/10) % cyfra.Count;
            index2 = ((index2 % 100) / 10)  % cyfra.Count;
            index3 = ((index3 % 100) / 10)  % cyfra.Count;
            pictureBox5.Image = cyfra[index];
            pictureBox2.Image = cyfra[index2];
            pictureBox1.Image = cyfra[index3];

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            int a, b, c;
            aktualny = DateTime.Now;

            a = aktualny.Second;
            b = aktualny.Minute;
            c = aktualny.Hour;
            change(a, b, c);
            change2(a, b, c);




        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
