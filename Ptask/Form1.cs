namespace BasicComputation
{
    // Paala, James P.          BSIT - 501
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void compute_btn_Click(object sender, EventArgs e)
        {
            if (fNum.Text == "" || sNum.Text == "")
            {
                MessageBox.Show("Fill up the missing inputs");
            }
            else if (operatorCmb.Text == "")
            {
                MessageBox.Show("Error: Choose operator!");
            }
            else
            {
                BasicComputation basicComputation = new BasicComputation();
                float fnum = (float)Convert.ToDouble(fNum.Text);
                float snum = (float)Convert.ToDouble(sNum.Text);

                if (operatorCmb.Text == "+")
                {
                    totalViews.Items.Clear();
                    float total = basicComputation.Addition(snum, fnum);
                    string result = total.ToString();
                    totalViews.Items.Add("Total:");
                    totalViews.Items.Add(result);
                }
                else if (operatorCmb.Text == "-")
                {
                    totalViews.Items.Clear();
                    float total = basicComputation.Subraction(snum, fnum);
                    string result = total.ToString();
                    totalViews.Items.Add("Total:");
                    totalViews.Items.Add(result);
                }
                else if (operatorCmb.Text == "*")
                {
                    totalViews.Items.Clear();
                    float total = basicComputation.Multiplication(snum, fnum);
                    string result = total.ToString();
                    totalViews.Items.Add("Total:");
                    totalViews.Items.Add(result);
                }
                else if (operatorCmb.Text == "/")
                {

                    totalViews.Items.Clear();
                    float total = basicComputation.Division(snum, fnum);
                    string result = total.ToString();
                    totalViews.Items.Add("Total:");
                    totalViews.Items.Add(result);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
