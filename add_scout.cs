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
    public partial class add_scout : Form
    {
        public add_scout()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Rent");
            comboBox1.Items.Add("Ownership");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Room");
            comboBox2.Items.Add("Flat");
            comboBox2.Items.Add("House");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Add("Bricks");
            comboBox3.Items.Add("Concrete");
            comboBox3.Items.Add("straw");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            departments new_form = new departments();
            new_form.Show();
        }
    }
}
