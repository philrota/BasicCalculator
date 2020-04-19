using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{   /// <summary>
/// A basic calculator
/// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Click(object sender, EventArgs e)
        {

        }

        #region Clearing methods
        private void DelBtn_Click(object sender, EventArgs e)
        {
            Delete();
            FocusInputText();

        }

     
        private void CButton_Click(object sender, EventArgs e)
        {

        }
        private void CE_Click(object sender, EventArgs e)
        {   //clears user imput text
            this.UserInputText.Text = string.Empty;
            FocusInputText();
        }
        #endregion

        #region Numbers methods 
        private void button3_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        

        private void btn1_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }
        

        private void btn2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();

        }

       
        private void Period_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }

       

        #endregion
        
        #region Operators methods

        private void Add_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }
        private void Subtract_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            CalculateEquation();
            FocusInputText();
        }

      
        #endregion

        #region Private helpers
        private void FocusInputText()
        {//focus the input field
            this.UserInputText.Focus();
        }
        private void InsertTextValue(string v)
        {
            //track the selection start
            var selectionStart = this.UserInputText.SelectionStart;
            //set the new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart,v);
            //restore the selection start
            this.UserInputText.SelectionStart = selectionStart + v.Length;
            //set the selection lenght to 0
            this.UserInputText.SelectionLength = 0;
        }
        private void CalculateEquation()
        {
            FocusInputText();
        }
        private void Delete()
        {
            
            //if we don't have a value to delete -> return nothing
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;
            
            //remeber the selection
            var selectionStart = this.UserInputText.SelectionStart;
            //delete the character to the right of the selection
            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);

            //restore the selection start
            this.UserInputText.SelectionStart = selectionStart;
            
            //set the selection lenght to 0
            this.UserInputText.SelectionLength = 0;
        }


        #endregion
    }
}
