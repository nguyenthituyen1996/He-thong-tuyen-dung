using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongtrinhQuayso
{
    public partial class Form1 : Form
    {
        int diem = 0;
        Random rand;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int so1 = rand.Next(1, 9);
                int so2 = rand.Next(1, 9);
                int so3 = rand.Next(1, 9);

                if (so1 == so2 && so2 == so3 && so1 == so3)
                {
                    diem = diem + 100;
                    lbKetqua.Text = diem.ToString();
                }
                else
                {
                    diem = diem - 10;
                    lbKetqua.Text = diem.ToString();
                }
                lb1.Text = so1.ToString();
                lb2.Text = so2.ToString();
                lb3.Text = so3.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn phải nhập số");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
           
        }
    }
}
