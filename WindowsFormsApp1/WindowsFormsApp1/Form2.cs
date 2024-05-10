using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void مشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            costomer costomer1 = new costomer();
            costomer1.Show();
        }

        private void کالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kala kala2 = new kala();
            kala2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
