using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterationAndSelectionStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Mooney")
            {
                MessageBox.Show("Howdy Mooney");
            }

           else if (comboBox1.Text == "MoonBear")
            {
                MessageBox.Show("wooo");
            }

            else if (comboBox1.Text == "MoonSlice")
            {
                MessageBox.Show("Still Workin");
            }

            else if (comboBox1.Text == "MoonBeam")
            {
                MessageBox.Show("happy Days!");
            }

            else
            {
                MessageBox.Show("WRONG!");
            }
        }
    }
}
