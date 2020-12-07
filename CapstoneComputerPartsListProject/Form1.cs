using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneComputerPartsListProject
{
        //************************************
        //Title:PCPartPickerList
        //Application Type: WINForm Application
        //Description: (describe the purpose and function)
        //Author: Spencer Bird 
        //Date Created: 11/30/2020
        //Last Modified: 12/6/2020 @ 10:30 PM EST
        //************************************
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //add part to file --Note to cite web source from where you found streamwriter
        {

            string addPart = txtBox_multilinePart.Text;
            
            string selectedPart = listbox_ComputerParts.SelectedItem.ToString(); //initializes the selected computer part on the listbox to be entered onto the txt file


            File.AppendAllText(@"partFiles\partList.txt", selectedPart + "\n" + addPart + "\n\n"); //writes text to partList.txt file and appends two new lines so that future additions will not be written over
            
            txtBox_multilinePart.Clear(); //clears multiline txt box after entry 

            
            rtb_partListReader.Text = File.ReadAllText(@"partFiles\partList.txt"); //reads .txt file and then displays text in RichTextBox 
            
            //code not authored by me, found similar solution and modified it from https://stackoverflow.com/questions/22171767/how-to-read-textfile-line-by-line-into-richtextbox
        }
        private void btn_calculatorWindow_Click(object sender, EventArgs e)
        {

            Form newWindow = new CalculatorForm(); // initializes the calculator form 

            newWindow.Show(); //opens up the calculator window
        }

        private void btn_closeProgram_Click(object sender, EventArgs e)
        {
            //closes the program entirely 
            Close();
        }

        private void lbl_multiline_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_mainTitle_Click(object sender, EventArgs e)
        {

        }

        private void listbox_ComputerParts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_partlistRead_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
