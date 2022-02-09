using System;
using System.Drawing;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Math_Quiz : Form
    {
        Random random = new Random();

        int plus1;
        int plus2;

        int minus1;
        int minus2;

        int multiply1;
        int multiply2;

        int division1;
        int division2;

        int timeLeft;

        public Math_Quiz()
        {
            InitializeComponent();
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        private void StartQuiz()
        {
            Sum.Value = 0;
            Minus.Value = 0;
            Multiply.Value = 0;
            Division.Value = 0;

            //Sum
            plus1 = random.Next(10);
            NumberLeftPlus.Text = plus1.ToString();

            plus2 = random.Next(10);
            NumberRightPlus.Text = plus2.ToString();

            //Minus
            minus1 = random.Next(1,10);
            NumberLeftMinus.Text = minus1.ToString();

            minus2 = random.Next(1, minus1);
            NumberRightMinus.Text = minus2.ToString();

            //Multiply
            multiply1 = random.Next(1, 10);
            NumberLeftMultiply.Text = minus1.ToString();

            multiply2 = random.Next(1, 10);
            NumberRightMultiply.Text = multiply2.ToString();

            //Division
            division2 = random.Next(1,10);
            NumberRightDivision.Text = division2.ToString();
            int p = random.Next(1, 10);

            division1 = p * division2;
            NumberLeftDivision.Text = division1.ToString();

            timeLeft = 18;
            TimeLeftLabel.Text = "18 seconds";
            timer1.Start();

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CheckResult())
            {
                timer1.Stop();
                MessageBox.Show("Congratulation!");
            }
            else if (timeLeft > 0)
            {
               if(timeLeft == 6)
                {
                    TimeLeftLabel.ForeColor = Color.Red;
                }
                timeLeft--;
                TimeLeftLabel.Text = timeLeft + " seconds";
            }
            else
            {
                TimeLeftLabel.Text = "Sorry,but time is over :(";
            }   
        }

        public bool CheckResult()
        {
            if ((plus1 + plus2 == Sum.Value) &&
                (minus1 - minus2 == Minus.Value) &&
                (multiply1 * multiply2 == Multiply.Value) &&
                (division1 / division2 == Division.Value))

                return true;
            else
                return false;
        }
    }
}
