
namespace RekenMachine
{
    public partial class Form1 : Form
    {
        string mode = string.Empty;
        string first = string.Empty;
        string last = string.Empty;
        string resultS = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            mode = "+";
            UpdateText();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            mode = "-";
            UpdateText();

        }

        private void calc_Click(object sender, EventArgs e)
        {
            if (first != string.Empty && last != string.Empty)
            {

                if (mode == "+")
                {
                   resultS = (int.Parse(first) + int.Parse(last)).ToString();
                }
                else if (mode == "-")
                {
                    resultS = (int.Parse(first) - int.Parse(last)).ToString();

                }
                UpdateText();
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            setNumber(9);

        }

        private void eigth_Click(object sender, EventArgs e)
        {
            setNumber(8);

        }

        private void seven_Click(object sender, EventArgs e)
        {
            setNumber(7);

        }

        private void six_Click(object sender, EventArgs e)
        {
            setNumber(6);

        }

        private void five_Click(object sender, EventArgs e)
        {
            setNumber(5);

        }

        private void four_Click(object sender, EventArgs e)
        {
            setNumber(4);

        }

        private void three_Click(object sender, EventArgs e)
        {

            setNumber(3);
        }

        private void two_Click(object sender, EventArgs e)
        {
            setNumber(2);

        }

        private void one_Click(object sender, EventArgs e)
        {
            setNumber(1);
        }

        public void UpdateText()
        {
            result.Text = $"{first} {mode} {last} = {resultS}";
        }
        public void setNumber(int number)
        {
            if (first == String.Empty)
            {
                first = number.ToString();
            }
            else if (last == String.Empty)
            {
                last = number.ToString();

            }
            else
            {
                first = number.ToString();
                last = string.Empty;
                resultS = string.Empty;
                mode = string.Empty;
            }
            UpdateText();
        }
    }
}
