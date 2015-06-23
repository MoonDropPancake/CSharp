using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] myArray = new string[2];
            //myArray[0] = "Potatoes";
            //myArray[1] = "Desert";

            //MessageBox.Show(myArray[1]);


            //string[] myArray = { "Potatoes", "Bitta Ham", "Lovely Cans", "pesgetti" };

            //foreach (var item in myArray)
            //{
            //    MessageBox.Show(item);
            //}


            string[] myArray = { "Potatoes", "Bitta Ham", "Lovely Cans", "pesgetti" };
            
            for (int index = 0; index < myArray.Length; index++)
            {
                MessageBox.Show(index.ToString());

                if (myArray[index] == "Lovely Cans")
                {
                  MessageBox.Show("Thats it!");
                }          
                }
        }
    }
}
