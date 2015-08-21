using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathParserTK;

namespace cst238lab2
{
    public partial class Calculator : Form
    {
        public double result = 0;
        public double storedNumber = 0;
        // if true, clears the textbox
        public bool specialEvent = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /// <summary>
        /// Make a message box and display some information about the author
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Anthony Nguyen, April 2015");
        }

        /// <summary>
        /// Copy the text in the textbox onto clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(mathText.Text);
        }

        /// <summary>
        /// Pastes whatever is on clipboard into textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mathText.Text = System.Windows.Forms.Clipboard.GetText();
        }

        /// <summary>
        /// Should display digits separated every 3 numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void digitGroupingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        /// <summary>
        /// Reads in the button text into the textbox for numbers and operators
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (mathText.Text == "0" || specialEvent)
                mathText.Text = button.Text;
            else
                mathText.Text += button.Text;

            specialEvent = false;
        }

        /// <summary>
        /// Clears the textbox and resets result value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCE_Click(object sender, EventArgs e)
        {
            mathText.Text = "0";
            result = 0;
        }

        /// <summary>
        /// Clears the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnC_Click(object sender, EventArgs e)
        {
            mathText.Text = "0";
        }

        /// <summary>
        /// Evaluates the string in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            MathParser parser = new MathParser();
            string equation = mathText.Text;
            bool isRadians = false;

            try
            {
                result = parser.Parse(equation, isRadians);
                mathText.Text = result.ToString();
                specialEvent = true;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Operation!");
            }
        }

        /// <summary>
        /// Deletes 1 character off of the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            int size = mathText.Text.Length - 1;
            if (size > 0)
                mathText.Text = mathText.Text.Substring(0, size);
            if (size == 0)
                mathText.Text = "0";
        }

        /// <summary>
        /// Gives the square root of the string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double numToRoot = Double.Parse(mathText.Text);

            if (numToRoot > 0)
            {
                mathText.Text = Math.Sqrt(numToRoot).ToString();
                specialEvent = true;
            }
        }

        /// <summary>
        /// Gives the reciprocal of the whole string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInverse_Click(object sender, EventArgs e)
        {
            double numToInvert = Double.Parse(mathText.Text);

            if (numToInvert > 0)
            {
                mathText.Text = (1 / numToInvert).ToString();
                specialEvent = true;
            }
        }

        /// <summary>
        /// Equation must have a value, an operation and a second value. 
        /// The 2nd value will be the percent of the first value and 
        /// will evaluate accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPercent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented");
        }

        /// <summary>
        /// Adjust the sign value of the string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (mathText.Text[0] == '-')
                mathText.Text = mathText.Text.Substring(1, mathText.Text.Length - 1);
            else
                if (mathText.Text != "0")
                    mathText.Text = "-" + mathText.Text;
        }

        /// <summary>
        /// Deals with memory keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMemory_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
        }

        /// <summary>
        /// Store the evaluated equation in the textbox and store it into a variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMS_Click(object sender, EventArgs e)
        {
            MathParser parser = new MathParser();
            string equation = mathText.Text;
            bool isRadians = false;

            try
            {
                storedNumber = parser.Parse(equation, isRadians);
                lblStoreNumber.Text = "M";
                specialEvent = true;
            }
            catch (InvalidOperationException)
            {

            }
        }

        /// <summary>
        /// Output the stored value into the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMR_Click(object sender, EventArgs e)
        {
            mathText.Text = storedNumber.ToString();
            specialEvent = false;
        }

        /// <summary>
        /// Clear stored number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMC_Click(object sender, EventArgs e)
        {
            storedNumber = 0;
            lblStoreNumber.Text = "";
        }

        /// <summary>
        /// Add to currently stored number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            MathParser parser = new MathParser();
            string equation = mathText.Text;
            bool isRadians = false;

            try
            {
                storedNumber += parser.Parse(equation, isRadians);
                lblStoreNumber.Text = "M";
                specialEvent = true;
            }
            catch (InvalidOperationException)
            {

            }
        }



    }
}
