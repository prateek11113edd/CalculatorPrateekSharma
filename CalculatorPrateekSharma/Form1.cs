using System.Linq.Expressions;

namespace CalculatorPrateekSharma
{
    public partial class Calculatorwin : Form
    {
        Double Result;
        string StoredOperation;
        bool OperationPerformed = false;
        public Calculatorwin()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            if ((Result_Box.Text == "0") || (OperationPerformed))
                Result_Box.Clear();
            OperationPerformed = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!Result_Box.Text.Contains("."))
                {
                    Result_Box.Text = Result_Box.Text + button.Text;

                }
            }
            else
                Result_Box.Text = Result_Box.Text + button.Text;

        }

        private void Result_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (Result != 0)
            {
                switch (StoredOperation)
                {
                    case "+":
                        Result_Box.Text = (Result + Double.Parse(Result_Box.Text)).ToString();
                        break;
                    case "-":
                        Result_Box.Text = (Result - Double.Parse(Result_Box.Text)).ToString();
                        break;
                    case "*":
                        Result_Box.Text = (Result * Double.Parse(Result_Box.Text)).ToString();
                        break;
                    case "/":
                        Result_Box.Text = (Result / Double.Parse(Result_Box.Text)).ToString();
                        break;
                    default:
                        break;
                }

                StoredOperation = button.Text;
                Result = Double.Parse(Result_Box.Text);
                OperationPerforming.Text = Result + " " + StoredOperation;
                OperationPerformed = true;
                Result = Double.Parse(Result_Box.Text);
               
            }
            StoredOperation = button.Text;
            Result = Double.Parse(Result_Box.Text);
            OperationPerforming.Text = Result + " " + StoredOperation;
            OperationPerformed = true;
            Result = Double.Parse(Result_Box.Text);
            

        }




        private void button5_Click(object sender, EventArgs e)
        {
            Result_Box.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Result_Box.Text = "0";
            Result = 0;

        }

       

        private void EqualTo_Click(object sender, EventArgs e)
        {
            switch (StoredOperation)
            {
                case "+":
                    Result_Box.Text = (Result + Double.Parse(Result_Box.Text)).ToString();
                    break;
                case "-":
                    Result_Box.Text = (Result - Double.Parse(Result_Box.Text)).ToString();
                    break;
                case "*":
                    Result_Box.Text = (Result * Double.Parse(Result_Box.Text)).ToString();
                    break;
                case "/":
                    Result_Box.Text = (Result / Double.Parse(Result_Box.Text)).ToString();
                    break;
                    default:
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string sum = "";
                int n, i;
                int[] a = new int[100];

                n = int.Parse(Result_Box.Text);
                for (i = 0; n > 0; i++)
                {
                    a[i] = n % 2;
                    n = n / 2;
                }

                for (i = i - 1; i >= 0; i--)
                {
                    sum = sum + a[i].ToString();
                }
                Result_Box.Text = sum;
            }
            catch
            {
                Result_Box.Text = "Error";
            }
    }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                Result_Box.Text = Convert.ToInt32(Result_Box.Text, 2).ToString(); // Refrence from StackOverload }
            }
            catch
            {
                Result_Box.Text = "Error";
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
         
        }
    }
}