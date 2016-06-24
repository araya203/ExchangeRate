using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        currency cur1;
        currency cur2;
        private class currency
        {
            
            public string Name;
            public double Value;
            public currency(string name, double value)
            {
                Name = name; 
                Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        public Form1()
        {
            
            
            InitializeComponent();
            comboBox1.Items.Add(new currency("Canadian Dollar", 1.2329));
            comboBox1.Items.Add(new currency("Swiss Franc", 0.9326));
            comboBox1.Items.Add(new currency("Pound Sterling", 0.6432));
            comboBox1.Items.Add(new currency("US Dollar", 1));
            comboBox1.Items.Add(new currency("Japanese Yen", 123.454));
            comboBox2.Items.Add(new currency("Canadian Dollar", 1.2329));
            comboBox2.Items.Add(new currency("Swiss Franc", 0.9326));
            comboBox2.Items.Add(new currency("Pound Sterling", 0.6432));
            comboBox2.Items.Add(new currency("US Dollar", 1));
            comboBox2.Items.Add(new currency("Japanese Yen", 123.454));

             }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur1 = (currency)comboBox1.SelectedItem;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double exchangeRate = cur2.Value / cur1.Value;
            label1.Text = cur1.Name.ToString();
            label2.Text = cur2.Name.ToString();
            label3.Text = "1";
            label4.Text = exchangeRate.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur2 = (currency)comboBox2.SelectedItem;

            // Display the Value property
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
    }
}
