namespace MyCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // Clear the default zero when number button is clicked
            if (txtResult.Text == "0")
            {
                txtResult.Text = "";
            }
            
            // Get the button that was clicked
            Button button = (Button)sender;
            // Print the number of the clicked button to the screen
            txtResult.Text = txtResult.Text + button.Text;

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnOperator_Click(object sender, EventArgs e)
        {

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains('.') is false)
            {
                // Get the button that was clicked
                Button button = (Button)sender;
                // Print the text '.' of the clicked button to the screen
                txtResult.Text = txtResult.Text + button.Text;
                btnDecimal.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
