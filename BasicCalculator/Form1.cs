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
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }

      

        private void btn4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        

        private void btn1_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }
        

        private void btn2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

        }

       
        private void Period_Click(object sender, EventArgs e)
        {

        }

        private void Equal_Click(object sender, EventArgs e)
        {

        }

        #endregion
        
        #region Operators methods

        private void Add_Click(object sender, EventArgs e)
        {

        }
        private void Subtract_Click(object sender, EventArgs e)
        {

        }
        private void Multiply_Click(object sender, EventArgs e)
        {

        }
        private void Divide_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Private helpers
        private void FocusInputText()
        {//focus the input field
            this.UserInputText.Focus();
        }
        private void InsertTextValue(string v)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart,v);
        }

        #endregion
    }
}
