﻿using System;
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
           
         //      if (comboBox1.Text == "Mooney")
         //   {
         //       MessageBox.Show("Howdy Mooney");
         //   }

         //  else if (comboBox1.Text == "MoonBear")
         //   {
         //       MessageBox.Show("wooo");
         //   }

         //   else if (comboBox1.Text == "MoonSlice")
         //   {
         //       MessageBox.Show("Still Workin");
         //   }

         //   else if (comboBox1.Text == "MoonBeam")
         //   {
         //       MessageBox.Show("happy Days!");
         //   }

         //   else
         // {
         //       MessageBox.Show("WRONG!");
         //} 
            
            
            
            if (comboBox1.Text != "Mooney")
            {
                if (comboBox1.Text == "MoonBear")
                {
                    MessageBox.Show("MoonBear?");
                }
                else
                {
                    MessageBox.Show("Who even are you?");
                }
            }
            else
            {
                MessageBox.Show("Wassup Mooney");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem.ToString())
            {
                case "Foobar":
                    MessageBox.Show("You Picked Foobar");
                    break;

                case "Bazquirk":
                    MessageBox.Show("You picked Bazquirk");
                    break;

                default:
                    MessageBox.Show("You picked wrong!");
                    break;
            }
            
            }
    }
}
