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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Agent newForm = new Agent();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerClients newForm = new ManagerClients();
            newForm.Show();
        }
    }
}
