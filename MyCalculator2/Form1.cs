using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyCalculator2
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        System.String operatorChosen = "";
        bool isOperatorChosen = false;
        bool isSummedUp = false;
        bool errorOccured = false;
        bool isOperatorInTheEquation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // 1st case: Clear the default zero when number button is clicked
            // or
            // 2nd case: Clear the first result value when the second one is selected (right side of the equation)
            if ((txtResult.Text == "0") || (isOperatorChosen is true))
            {
                txtResult.Text = "";
            }
            // If already summarized, start the operation from the beginning after selecting the number
            else if (isSummedUp is true)
            {
                txtResult.Text = "";
                resultValue = 0;
            }
            // Clear the label above textbox to remove the div/0 error message
            if (errorOccured is true)
            {
                lblPendingVal.Text = "";
            }
            // Get the button that was clicked
            Button button = (Button)sender;
            // Print text of the clicked button: add it any time it is clicked
            txtResult.Text = txtResult.Text + button.Text;
            isOperatorChosen = false;
            isSummedUp = false;
            errorOccured = false;
            btnPlus.BackColor = SystemColors.ControlLightLight;
            btnPlus.Enabled = true;
            btnMinus.BackColor = SystemColors.ControlLightLight;
            btnMinus.Enabled = true;
            btnMulti.BackColor = SystemColors.ControlLightLight;
            btnMulti.Enabled = true;
            btnDivide.BackColor = SystemColors.ControlLightLight;
            btnDivide.Enabled = true;
            btnDecimal.BackColor = SystemColors.ControlLightLight;
            btnDecimal.Enabled = true;
            btnClearEntry.BackColor = SystemColors.ControlLight;
            btnClearEntry.Enabled = true;
            btnEquals.BackColor = SystemColors.ControlLight;
            btnEquals.Enabled = true;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // 1st case: Blocked the option to click only equal-to sign many times
            // or
            // 2nd case: If operator is not chosen at all - summing up won't be active
            if (isSummedUp is true || isOperatorInTheEquation is false)
            { 
                // Do nothing
            }
            else
            {
                if (errorOccured is true)
                {
                    // Perform 'click' event of the clear button
                    btnClear.PerformClick();
                }
                else
                {
                    // Perform calculation depending on operator chosen,
                    // between the value passed after clicking operator, and the one passed after summing up
                    switch (operatorChosen)
                    {
                        case "+":
                            txtResult.Text = (resultValue + Double.Parse(txtResult.Text)).ToString();
                            break;
                        case "-":
                            txtResult.Text = (resultValue - Double.Parse(txtResult.Text)).ToString();
                            break;
                        case "*":
                            txtResult.Text = (resultValue * Double.Parse(txtResult.Text)).ToString();
                            break;
                        case "/":
                            // Avoid dividing by zero
                            if (txtResult.Text == "0")
                            {
                                resultValue = 0;
                                lblPendingVal.Text = "Dividing by zero undefined";
                                errorOccured = true;
                                btnPlus.BackColor = SystemColors.ControlDark;
                                btnPlus.Enabled = false;
                                btnMinus.BackColor = SystemColors.ControlDark;
                                btnMinus.Enabled = false;
                                btnMulti.BackColor = SystemColors.ControlDark;
                                btnMulti.Enabled = false;
                                btnDivide.BackColor = SystemColors.ControlDark;
                                btnDivide.Enabled = false;
                                btnDecimal.BackColor = SystemColors.ControlDark;
                                btnDecimal.Enabled = false;
                                btnClearEntry.BackColor = SystemColors.ControlDark;
                                btnClearEntry.Enabled = false;
                            }
                            else
                            {
                                txtResult.Text = (resultValue / Double.Parse(txtResult.Text)).ToString();
                            }
                            break;
                        default:
                            break;
                    }
                    // Transfer the value in textbox to result
                    resultValue = Double.Parse(txtResult.Text);
                    if (lblPendingVal.Text != "Dividing by zero undefined")
                    {
                        lblPendingVal.Text = "";
                    }
                    isSummedUp = true;
                    isOperatorInTheEquation = false;
                    btnEquals.BackColor = SystemColors.ControlDark;
                    btnEquals.Enabled = false;
                }
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            // 1st case: Blocked the option to click operator right after error occurance
            // or
            // 2nd case: Blocked the option to click only operator many times
            if (errorOccured is true || isOperatorChosen is true)
            {
                // Do nothing
            }
            else
            {
                // Get the button that was clicked
                Button button = (Button)sender;

                // Sum up while choosing operator multiple times (without equal-to sign)
                if (resultValue != 0 & isSummedUp is false)
                {
                    // Perform 'click' event of the equal-to button
                    btnEquals.PerformClick();
                    if (lblPendingVal.Text == "Dividing by zero undefined")
                    {
                        // Do nothing
                    }
                    else
                    {
                        // Save information what operator was clicked
                        operatorChosen = button.Text;
                        // Print equation above textbox
                        lblPendingVal.Text = resultValue + " " + operatorChosen;
                        isOperatorChosen = true;
                        isOperatorInTheEquation = true;
                        btnPlus.BackColor = SystemColors.ControlDark;
                        btnPlus.Enabled = false;
                        btnMinus.BackColor = SystemColors.ControlDark;
                        btnMinus.Enabled = false;
                        btnMulti.BackColor = SystemColors.ControlDark;
                        btnMulti.Enabled = false;
                        btnDivide.BackColor = SystemColors.ControlDark;
                        btnDivide.Enabled = false;
                        btnDecimal.BackColor = SystemColors.ControlLightLight;
                        btnDecimal.Enabled = true;
                    }
                }
                else
                {
                    // Save information what operator was clicked
                    operatorChosen = button.Text;
                    // Pass number stored in textbox to resultValue variable
                    resultValue = Double.Parse(txtResult.Text);
                    // Print equation above textbox
                    lblPendingVal.Text = resultValue + " " + operatorChosen;
                    isOperatorChosen = true;
                    isOperatorInTheEquation = true;
                    btnPlus.BackColor = SystemColors.ControlDark;
                    btnPlus.Enabled = false;
                    btnMinus.BackColor = SystemColors.ControlDark;
                    btnMinus.Enabled = false;
                    btnMulti.BackColor = SystemColors.ControlDark;
                    btnMulti.Enabled = false;
                    btnDivide.BackColor = SystemColors.ControlDark;
                    btnDivide.Enabled = false;
                    errorOccured = false;
                    btnDecimal.BackColor = SystemColors.ControlLightLight;
                    btnDecimal.Enabled = true;
                }
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (errorOccured is true)
            {
                // Do nothing
            }
            else
            {
                // Get the button that was clicked
                Button button = (Button)sender;
                // Allow only one decimal point per value
                if (txtResult.Text.Contains(button.Text) is false)
                {
                    // Print text of the clicked button
                    txtResult.Text = txtResult.Text + button.Text;
                    btnDecimal.BackColor = SystemColors.ControlDark;
                    btnDecimal.Enabled = false;
                    //isOperatorChosen = false;
                    //isOperatorInTheEquation = false;
                    //errorOccured = false;
                    isSummedUp = false;
                }
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            if (errorOccured is true)
            {
                // Do nothing
            }
            else
            {
                // If current stage is right after summing up, clear also the result stored
                if (isSummedUp is true)
                {
                    txtResult.Text = "0";
                    resultValue = 0;
                    isSummedUp = false;
                }
                else
                {
                    txtResult.Text = "0";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
            lblPendingVal.Text = "";
            isOperatorChosen = false;
            isSummedUp = false;
            operatorChosen = "";
            errorOccured = false;
            btnPlus.BackColor = SystemColors.ControlLightLight;
            btnPlus.Enabled = true;
            btnMinus.BackColor = SystemColors.ControlLightLight;
            btnMinus.Enabled = true;
            btnMulti.BackColor = SystemColors.ControlLightLight;
            btnMulti.Enabled = true;
            btnDivide.BackColor = SystemColors.ControlLightLight;
            btnDivide.Enabled = true;
            btnDecimal.BackColor = SystemColors.ControlLightLight;
            btnDecimal.Enabled = true;
            btnClearEntry.BackColor = SystemColors.ControlLight;
            btnClearEntry.Enabled = true;
        }
    }
}
