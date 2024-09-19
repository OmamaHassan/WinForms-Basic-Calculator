namespace WinFormsAppCalculator
{
    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResult.Text = "";
            comboOpe.SelectedIndex = -1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (ValidateInput(txtNum1.Text))
            {
                MessageBox.Show("Enter a valid value for field 'Number1'.");
            }

            else if (ValidateInput(txtNum2.Text))
            {
                MessageBox.Show("Enter a valid value for field 'Number2'.");
            }

            else if (comboOpe.SelectedIndex == -1)
            {
                MessageBox.Show("Select Operation To Be Performed.");
            }

            else
            {
                double num1 = Convert.ToDouble(txtNum1.Text),
                       num2 = Convert.ToDouble(txtNum2.Text),
                       result = 0;

                if (comboOpe.SelectedIndex == 0)
                {
                    result = num1 + num2;
                }
                else if (comboOpe.SelectedIndex == 1)
                {
                    result = num1 - num2;
                }
                else if (comboOpe.SelectedIndex == 2)
                {
                    result = num1 * num2;
                }
                else
                {
                    result = num1 / num2;
                }
             txtResult.Text = result.ToString();
            }
        }
        private bool ValidateInput(string input)
        {
            if (!double.TryParse(input, out _))
                return true;
            else
                return false;
        }

        private void comboOpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtResult.Text = "";
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
