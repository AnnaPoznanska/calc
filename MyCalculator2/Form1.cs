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
            Button button = (Button)sender;
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

        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
