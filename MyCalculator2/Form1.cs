namespace MyCalculator2
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operatorChosen = "";
        bool isOperatorChosen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // 1st: Clear the default zero when number button is clicked
            // 2nd: Clear the first result value when the second one is selected (right side of the equation)
            if ((txtResult.Text == "0") || (isOperatorChosen is true))
            {
                txtResult.Text = "";
            }
            
            // Get the button that was clicked
            Button button = (Button)sender;
            // Print text of the clicked button: add it any time it is clicked
            txtResult.Text = txtResult.Text + button.Text;
            isOperatorChosen = false;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Perform calculation depending on operator chosen
            // On the left side of the equation is the value passed after operator is clicked
            // On the right side: the value passed after equals sign is clicked
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
                    txtResult.Text = (resultValue / Double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            // Get the button that was clicked
            Button button = (Button)sender;
            // Save information what operator was clicked
            operatorChosen = button.Text;
            // Pass number stored in textbox to resultValue variable
            resultValue = Double.Parse(txtResult.Text);
            // Print equation above textbox
            lblPendingVal.Text = resultValue + " " + operatorChosen;
            isOperatorChosen = true;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
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
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            resultValue = 0;
        }
    }
}
