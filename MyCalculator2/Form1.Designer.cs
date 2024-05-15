namespace MyCalculator2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnDivide = new Button();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnMulti = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnEquals = new Button();
            btnPlus = new Button();
            btnDecimal = new Button();
            btnZero = new Button();
            btnMinus = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            txtResult = new TextBox();
            lblPendingVal = new Label();
            lblPendingValDescr = new Label();
            SuspendLayout();
            // 
            // btnSeven
            // 
            btnSeven.BackColor = SystemColors.ControlLightLight;
            btnSeven.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeven.Location = new Point(25, 185);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(65, 65);
            btnSeven.TabIndex = 2;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnNumber_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.ControlLightLight;
            btnEight.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEight.Location = new Point(120, 185);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(65, 65);
            btnEight.TabIndex = 3;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnNumber_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.ControlLightLight;
            btnNine.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNine.Location = new Point(215, 185);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(65, 65);
            btnNine.TabIndex = 4;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNumber_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ControlLightLight;
            btnDivide.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(310, 185);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(65, 65);
            btnDivide.TabIndex = 5;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnOperator_Click;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = SystemColors.ControlLight;
            btnClearEntry.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearEntry.Location = new Point(405, 185);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(65, 65);
            btnClearEntry.TabIndex = 6;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(405, 272);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(65, 65);
            btnClear.TabIndex = 11;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.ControlLightLight;
            btnMulti.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMulti.Location = new Point(310, 272);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(65, 65);
            btnMulti.TabIndex = 10;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnOperator_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.ControlLightLight;
            btnSix.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSix.Location = new Point(215, 272);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(65, 65);
            btnSix.TabIndex = 9;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnNumber_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.ControlLightLight;
            btnFive.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFive.Location = new Point(120, 272);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(65, 65);
            btnFive.TabIndex = 8;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnNumber_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.ControlLightLight;
            btnFour.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFour.Location = new Point(25, 272);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(65, 65);
            btnFour.TabIndex = 7;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnNumber_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.ControlLight;
            btnEquals.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEquals.Location = new Point(405, 356);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(65, 152);
            btnEquals.TabIndex = 21;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ControlLightLight;
            btnPlus.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(310, 443);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(65, 65);
            btnPlus.TabIndex = 20;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnOperator_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = SystemColors.ControlLightLight;
            btnDecimal.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecimal.Location = new Point(215, 443);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(65, 65);
            btnDecimal.TabIndex = 19;
            btnDecimal.Text = ",";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.ControlLightLight;
            btnZero.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(26, 443);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(160, 65);
            btnZero.TabIndex = 17;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnNumber_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ControlLightLight;
            btnMinus.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(310, 356);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(65, 65);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnOperator_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = SystemColors.ControlLightLight;
            btnThree.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThree.Location = new Point(215, 356);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(65, 65);
            btnThree.TabIndex = 14;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnNumber_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.ControlLightLight;
            btnTwo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwo.Location = new Point(120, 356);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(65, 65);
            btnTwo.TabIndex = 13;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnNumber_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.ControlLightLight;
            btnOne.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOne.Location = new Point(25, 356);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(65, 65);
            btnOne.TabIndex = 12;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnNumber_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtResult.Location = new Point(26, 93);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(444, 50);
            txtResult.TabIndex = 22;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // lblPendingVal
            // 
            lblPendingVal.AutoSize = true;
            lblPendingVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPendingVal.ForeColor = Color.Gray;
            lblPendingVal.Location = new Point(26, 45);
            lblPendingVal.Name = "lblPendingVal";
            lblPendingVal.Size = new Size(38, 45);
            lblPendingVal.TabIndex = 24;
            // 
            // lblPendingValDescr
            // 
            lblPendingValDescr.AutoSize = true;
            lblPendingValDescr.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingValDescr.ForeColor = Color.Gray;
            lblPendingValDescr.Location = new Point(25, 17);
            lblPendingValDescr.Name = "lblPendingValDescr";
            lblPendingValDescr.Size = new Size(148, 28);
            lblPendingValDescr.TabIndex = 25;
            lblPendingValDescr.Text = "Pending Value:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(495, 555);
            Controls.Add(lblPendingValDescr);
            Controls.Add(lblPendingVal);
            Controls.Add(txtResult);
            Controls.Add(btnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnDecimal);
            Controls.Add(btnZero);
            Controls.Add(btnMinus);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnClear);
            Controls.Add(btnMulti);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnClearEntry);
            Controls.Add(btnDivide);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnDivide;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnMulti;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnEquals;
        private Button btnPlus;
        private Button btnDecimal;
        private Button btnZero;
        private Button btnMinus;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private TextBox txtResult;
        private Label lblPendingVal;
        private Label lblPendingValDescr;
    }
}
