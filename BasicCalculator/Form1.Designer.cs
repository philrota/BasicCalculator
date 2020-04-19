namespace BasicCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Equal = new System.Windows.Forms.Button();
            this.Period = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.CButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(2, 2);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(318, 20);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultText.Location = new System.Drawing.Point(2, 27);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(318, 20);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Please enter an equation and press Enter or =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.Equal, 3, 4);
            this.ButtonsPanel.Controls.Add(this.Period, 2, 4);
            this.ButtonsPanel.Controls.Add(this.btn0, 1, 4);
            this.ButtonsPanel.Controls.Add(this.Add, 3, 3);
            this.ButtonsPanel.Controls.Add(this.btn3, 2, 3);
            this.ButtonsPanel.Controls.Add(this.btn2, 1, 3);
            this.ButtonsPanel.Controls.Add(this.btn1, 0, 3);
            this.ButtonsPanel.Controls.Add(this.Subtract, 3, 2);
            this.ButtonsPanel.Controls.Add(this.btn6, 2, 2);
            this.ButtonsPanel.Controls.Add(this.btn5, 1, 2);
            this.ButtonsPanel.Controls.Add(this.btn4, 0, 2);
            this.ButtonsPanel.Controls.Add(this.Multiply, 3, 1);
            this.ButtonsPanel.Controls.Add(this.btn9, 2, 1);
            this.ButtonsPanel.Controls.Add(this.btn8, 1, 1);
            this.ButtonsPanel.Controls.Add(this.btn7, 0, 1);
            this.ButtonsPanel.Controls.Add(this.Divide, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DelBtn, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CE, 0, 0);
            this.ButtonsPanel.Controls.Add(this.CButton, 1, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(5, 48);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(315, 314);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // Equal
            // 
            this.Equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equal.Location = new System.Drawing.Point(237, 251);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(75, 60);
            this.Equal.TabIndex = 19;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Period
            // 
            this.Period.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Period.Location = new System.Drawing.Point(159, 251);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(72, 60);
            this.Period.TabIndex = 18;
            this.Period.Text = ".";
            this.Period.UseVisualStyleBackColor = true;
            this.Period.Click += new System.EventHandler(this.Period_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(81, 251);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(72, 60);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(237, 189);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 56);
            this.Add.TabIndex = 15;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(159, 189);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 56);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(81, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 56);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 189);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 56);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Subtract
            // 
            this.Subtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subtract.Location = new System.Drawing.Point(237, 127);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(75, 56);
            this.Subtract.TabIndex = 11;
            this.Subtract.Text = "--";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(159, 127);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 56);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(81, 127);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 56);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 127);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 56);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Multiply
            // 
            this.Multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiply.Location = new System.Drawing.Point(237, 65);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(75, 56);
            this.Multiply.TabIndex = 7;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(159, 65);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 56);
            this.btn9.TabIndex = 6;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(81, 65);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 56);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 65);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 56);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button3_Click);
            // 
            // Divide
            // 
            this.Divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divide.Location = new System.Drawing.Point(237, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(75, 56);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "%";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelBtn.Location = new System.Drawing.Point(159, 3);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(72, 56);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "Del";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // CE
            // 
            this.CE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CE.Location = new System.Drawing.Point(3, 3);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(72, 56);
            this.CE.TabIndex = 0;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // CButton
            // 
            this.CButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CButton.Location = new System.Drawing.Point(81, 3);
            this.CButton.Name = "CButton";
            this.CButton.Size = new System.Drawing.Size(72, 56);
            this.CButton.TabIndex = 1;
            this.CButton.Text = "C";
            this.CButton.UseVisualStyleBackColor = true;
            this.CButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CE;
            this.ClientSize = new System.Drawing.Size(322, 374);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MaximumSize = new System.Drawing.Size(500, 520);
            this.MinimumSize = new System.Drawing.Size(244, 236);
            this.Name = "Form1";
            this.Text = "Basic Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button CButton;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Period;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button DelBtn;
    }
}

