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
    public partial class add_education : Form
    {
        public string path = null;
        public add_education()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                pictureBox1.Image = Image.FromFile(path);
                MessageBox.Show(path);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            departments new_form = new departments();
            new_form.Show();
        }
    }
}
