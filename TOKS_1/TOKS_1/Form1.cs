using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOKS_1
{
    public partial class Form1 : Form
    {
        Class1 class1 = new Class1();
        private void UpdateCompPortComboBox1()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());
        }
   
        public Form1()
        {
            InitializeComponent();
            UpdateCompPortComboBox1();
           



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Enabled = false;
                checkBox1.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            class1.serialPort_DataReceived(); ;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            class1.Form1_Load();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
