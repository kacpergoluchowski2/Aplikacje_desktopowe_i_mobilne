namespace FirstMauiApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        async private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            if (count % 2 == 0)
            {
                await Icon.RotateTo(2700, 30000);
                Description.Text = "siurek";
                Icon.Rotation = 0;
                await Description.ScaleTo(0.5, 3500);
            }
            else
            {
                await Icon.RotateTo(-2700, 30000);
                Description.Text = "siur";
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
            SemanticScreenReader.Announce(Description.Text);
        }
    }


}
