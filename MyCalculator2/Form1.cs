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
            //If already summarized, start the operation from the beginning after selecting the number
            else if (isSummedUp is true)
            {
                txtResult.Text = "";
                resultValue = 0;
            }
            // Clear the label above textbox to remove the div/0 error message
            if (errorOccured is true) //not else if
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
            btnMinus.BackColor = SystemColors.ControlLightLight;
            btnMulti.BackColor = SystemColors.ControlLightLight;
            btnDivide.BackColor = SystemColors.ControlLightLight;
            btnDecimal.BackColor = SystemColors.ControlLightLight;
            btnClearEntry.BackColor = SystemColors.ControlLight;
            btnEquals.BackColor = SystemColors.ControlLight;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // 1st case: Blocked the option to click only equal-to sign many times
            // or
            // 2nd case: If operator is not chosen at all - summing up won't be active
            if (isSummedUp is true || isOperatorChosen is false)
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
                    // Perform calculation depending on operator chosen
                    // Between the value after choosing operator, and the one after summing up
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
                                //txtResult.Text = "";
                                resultValue = 0;
                                lblPendingVal.Text = "Dividing by zero undefined";
                                errorOccured = true;
                                btnPlus.BackColor = SystemColors.ControlDark;
                                btnMinus.BackColor = SystemColors.ControlDark;
                                btnMulti.BackColor = SystemColors.ControlDark;
                                btnDivide.BackColor = SystemColors.ControlDark;
                                btnDecimal.BackColor = SystemColors.ControlDark;
                                btnClearEntry.BackColor = SystemColors.ControlDark;
                            }
                            else
                            {
                                txtResult.Text = (resultValue / Double.Parse(txtResult.Text)).ToString();
                            }
                            //txtResult.Text = (resultValue / Double.Parse(txtResult.Text)).ToString();
                            break;
                        default:
                            break;
                    }
                    // Transfer the value in textbox to result
                    resultValue = Double.Parse(txtResult.Text);
                    if (lblPendingVal.Text != "Dividing by zero undefined") // think where to move it
                    {
                        lblPendingVal.Text = "";
                    }
                    isSummedUp = true;
                    btnEquals.BackColor = SystemColors.ControlDark;
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
                        btnPlus.BackColor = SystemColors.ControlDark;
                        btnMinus.BackColor = SystemColors.ControlDark;
                        btnMulti.BackColor = SystemColors.ControlDark;
                        btnDivide.BackColor = SystemColors.ControlDark;
                        btnDecimal.BackColor = SystemColors.ControlLightLight;
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
                    btnPlus.BackColor = SystemColors.ControlDark;
                    btnMinus.BackColor = SystemColors.ControlDark;
                    btnMulti.BackColor = SystemColors.ControlDark;
                    btnDivide.BackColor = SystemColors.ControlDark;
                    errorOccured = false;
                    btnDecimal.BackColor = SystemColors.ControlLightLight;
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
                    btnDecimal.BackColor = SystemColors.ControlDarkDark;
                    isOperatorChosen = false;
                    errorOccured = false;
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
                txtResult.Text = "0";
                isOperatorChosen = false; //new
                errorOccured = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
            lblPendingVal.Text = "";
            isOperatorChosen = false; //new
            isSummedUp = false; //new
            operatorChosen = ""; //new
            errorOccured = false;
            btnPlus.BackColor = SystemColors.ControlLightLight;
            btnMinus.BackColor = SystemColors.ControlLightLight;
            btnMulti.BackColor = SystemColors.ControlLightLight;
            btnDivide.BackColor = SystemColors.ControlLightLight;
            btnDecimal.BackColor = SystemColors.ControlLightLight;
            btnClearEntry.BackColor = SystemColors.ControlLight;
        }
    }
}
