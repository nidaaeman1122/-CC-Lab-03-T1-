using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03_T1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void validateButton_Click(object sender, EventArgs e)
        {
            string input = inputTextBox.Text; // Get the input from the TextBox

            // Regular expression pattern for floating point numbers with max length 6
            string pattern = @"^-?\d{1,5}(\.\d{1,4})?$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Check if the input matches the pattern and is within the length limit
            if (regex.IsMatch(input) && input.Length <= 6)
            {
                MessageBox.Show("Valid Floating Point Number", "Validation");
            }
            else
            {
                MessageBox.Show("Invalid Floating Point Number", "Validation");
            }
        }
    }
}
