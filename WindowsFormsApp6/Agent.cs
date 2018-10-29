using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Agent : Form
    {
        public Agent()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAgent newForm = new AddAgent();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
