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


            //string[] myArray = { "Potatoes", "Bitta Ham", "Lovely Cans", "pesgetti" };
            
            //for (int index = 0; index < myArray.Length; index++)
            //{
            //    MessageBox.Show(index.ToString());

            //    if (myArray[index] == "Lovely Cans")
            //    {
            //      MessageBox.Show("Thats it!");
            //    }          
            //    }


            string[] myArray = { "Potatoes", "Bitta Ham", "Lovely Cans", "pesgetti" };

            for (int index = 0; index < myArray.Length;)
            {
                foreach (var nickname in myArray)
               {
                  MessageBox.Show(index++ + "" + nickname);
               }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int index = 0; index < listBox1.SelectedItems.Count; index++)
            {
                switch (listBox1.SelectedItems[index].ToString())
                {
                    case "Potatoes":
                        MessageBox.Show("Potatoes");
                        break;

                    case "Bitta Ham":
                        MessageBox.Show("Bitta Ham");
                        break;

                    case "Lovely Cans":
                        MessageBox.Show("Lovely Cans");
                        break;

                    case "Pesgetti":
                        MessageBox.Show("Pesgetti");
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            while (i < int.Parse(textBox1.Text))
            {
                i++;
            }
            MessageBox.Show("The final value was:" + i.ToString());
        }
    }
}
