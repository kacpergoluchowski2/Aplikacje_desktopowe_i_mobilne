using Microsoft.Maui.Controls.Shapes;

namespace BindingRotationMauiApp
{
    public partial class MainPage : ContentPage
    {
        public string Message { get; set; }

        public string processedMessage;
        public string ProcessedMessage
        {
            get { return processedMessage; }
            set
            {
                processedMessage = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }

        private void level_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            messageLabel.Text = "Poziom Suwaka: " + level.Value;
            try
            {
                rotateLabel.Rotation = level.Value;
            } 
            catch (Exception err)
            {
                Console.WriteLine("Błąd " + err.Message);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string message = Message;

            int numberOfCharacters = message.Length;

            ProcessedMessage = "Ilość znaków w komunikacie: " + numberOfCharacters;
            OnPropertyChanged("ProcessedMessage");
        }
    }

}
