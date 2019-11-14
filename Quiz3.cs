using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public object myDisableValue { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            //radioButton1.Checked;
            // comboBoxMake.Items.Add("Honda");
            //  comboBoxMake.Items.Add("Lexus");

           // if (groupBox1.Enabled == true)
           // {
           //     groupBox2.Enabled = false;
           // }
                
           // else
               // groupBox1.Enabled = false;
            //    groupBox2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxModel.Items.Clear();

            //Honda
            if (comboBoxMake.SelectedIndex == 0)
            {
              //  comboBoxModel.Items.Clear();

                comboBoxModel.Items.Add("Civic");
                comboBoxModel.Items.Add("Accord");
                comboBoxModel.Items.Add("CRV");
                comboBoxModel.Items.Add("HRV");
            }

            //Lexus
            if (comboBoxMake.SelectedIndex == 1)
            {
               // comboBoxModel.Items.Clear();

                comboBoxModel.Items.Add("IS");
                comboBoxModel.Items.Add("RX");
                comboBoxModel.Items.Add("ES");
                comboBoxModel.Items.Add("LX");
            }

        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Year
            comboBoxYear.Items.Add("2015");
            comboBoxYear.Items.Add("2016");
            comboBoxYear.Items.Add("2017");
            comboBoxYear.Items.Add("2018");
            comboBoxYear.Items.Add("2019");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reset
            comboBoxYear.SelectedIndex = -1;
            comboBoxModel.SelectedIndex = -1;
            comboBoxMake.SelectedIndex = -1;
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty || textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the information in all fields");
                return; 
            }
           

            if (comboBoxMake.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("Please enter the information in all fields");
            }
            else
            {
                MessageBox.Show("Thank you!");


            }

            if (comboBoxModel.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("Please enter the information in all fields");
            }
            else
            {
                MessageBox.Show("Thank you!");
            }

            if (comboBoxYear.SelectedIndex == -1)//Nothing selected
            {
                MessageBox.Show("Please enter the information in all fields");
            }
            else
            {
                MessageBox.Show("Thank you!");
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = (@"C:\Users\1896360\Pictures");
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = saveFileDialog1.FileName;
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }
    }
}
