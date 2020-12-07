using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapstoneComputerPartsListProject
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            //created variables and initialized operands for textbox along with answer for empty double
            double operandOne, operandTwo, answer = 0;
            double.TryParse(txtbox_OperandOne.Text, out operandOne);
            double.TryParse(txtbox_OperandTwo.Text, out operandTwo);

            Button operation = sender as Button;

            //Switch/Case statement for initializing either addition or multiplication for simple calc
            switch (operation.Tag)
            {
                case "Add Part Price":
                    answer = operandOne + operandTwo;
                    break;

                case "Multiply Total":
                    answer = operandOne * operandTwo;
                    break;
                
                default:
                    break;
            }
        }

        private void btn_addPartPrice_Click(object sender, EventArgs e)
        {

            //variables initialized
            double operandOne, operandTwo, answer;
            
            //converts string to bool and initializes both operands for answer equation
            double.TryParse(txtbox_OperandOne.Text, out operandOne);
            double.TryParse(txtbox_OperandTwo.Text, out operandTwo);

            answer = operandOne + operandTwo;

            //clears text after addition has taken place
            txtbox_OperandOne.Clear();
            txtbox_OperandTwo.Clear();

            //sends answer to total txtbox
            txtbox_Total.Text = answer.ToString();
        }
        private void btn_multiply_Click(object sender, EventArgs e)
        {

            //variables initialized
            double operandOne, operandTwo, answer;

            //converts string to bool and initializes both operands for answer equation
            double.TryParse(txtbox_OperandOne.Text, out operandOne);
            double.TryParse(txtbox_OperandTwo.Text, out operandTwo);

            answer = operandOne * operandTwo;

            //clears text after addition has taken place
            txtbox_OperandOne.Clear();
            txtbox_OperandTwo.Clear();

            txtbox_Total.Text = answer.ToString();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btn_addToListBox_Click(object sender, EventArgs e)
        {

            //creation of variables used for text output
            string priceLabel = txtbox_WorkstationUnitLabel.Text;

            string priceUnits = txtbox_totalWorkstationsUnits.Text;

            string addPrice = txtbox_workstationPriceEntry.Text;
            
            //creates filepath to append 3 newlines inside partlist text for total price with the Workstation Label, the total units, and the total price
            File.AppendAllText(@"partFiles\PartList.txt", priceLabel + "\n" + "Price Total: $" + addPrice + "\n" + "unit(s): " + priceUnits);
            
            //clears all initial strings inside textbox for new Workstation price to be appended to text file
            txtbox_workstationPriceEntry.Clear();

            txtbox_totalWorkstationsUnits.Clear();

            txtbox_WorkstationUnitLabel.Clear();

            //shows new text file output inside of richtextbox inside the program from the file path designated
            //code not authored by me, found similar solution and modified it from https://stackoverflow.com/questions/22171767/how-to-read-textfile-line-by-line-into-richtextboxD
            rtb_filePriceOutput.Text = File.ReadAllText(@"partFiles\PartList.txt");

        }

        private void lbl_operandOne_Click(object sender, EventArgs e)
        {

        }


    }
}
