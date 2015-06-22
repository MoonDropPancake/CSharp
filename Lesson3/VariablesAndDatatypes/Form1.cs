using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesAndDatatypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //String hello;
            //hello = "hello world";
            //MessageBox.Show(hello);
            //MessageBox.Show("hello");
            
            String firstTextBox = textBox1.Text;
            String secondTextBox = textBox2.Text;

            label3.Text = firstTextBox + " " + secondTextBox;
        }
    }
}
