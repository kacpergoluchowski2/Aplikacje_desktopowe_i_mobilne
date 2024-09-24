// using Android.App;

namespace BsimpleCalculator
{
    public partial class MainPage : ContentPage
    {
        public string firstNumber { get; set; }
        public string secondNumber { get; set; }
        public bool additionButton { get; set; }
        public bool substractionButton { get; set; }
        public bool multiplicationButton { get; set; }
        public bool divisionButton { get; set; }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            string first = firstNumber;
            string second = secondNumber;

            int parsedFirst = Int32.Parse(firstNumber);
            int parsedSecond = Int32.Parse(secondNumber);


            if(additionButton)
            {
                float result = parsedFirst + parsedSecond;
                resultLabel.Text = result.ToString();
            } else if(substractionButton)
            {
                float result = parsedFirst - parsedSecond;
                resultLabel.Text = result.ToString();
            } else if(multiplicationButton)
            {
                float result = parsedFirst * parsedSecond;
                resultLabel.Text = result.ToString();
            } else if(divisionButton)
            {
                float result = parsedFirst / parsedSecond;
                resultLabel.Text = result.ToString();
            } else
            {
                resultLabel.Text = "prosze wybrać typ działania";
            }

        }
    }

}
