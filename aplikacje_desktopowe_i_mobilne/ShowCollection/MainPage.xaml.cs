using System.Collections.ObjectModel;

namespace ShowCollection
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection <string> FruitsCollection { get; set; }
        public string SelectedFruit { get; set; }
        public string selectedFruitMessage;
        public string SelectedFruitMessage 
        {
            get { 
                return selectedFruitMessage; 
            }
            set { 
                selectedFruitMessage = value;
                OnPropertyChanged();    
            }
        }
        public string NewFruit { get; set; }

        public MainPage()
        {
            FruitsCollection = new ObservableCollection<string>();

            FruitsCollection.Add("Banan");
            FruitsCollection.Add("Mandarynka");
            FruitsCollection.Add("Japko");
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            SelectedFruitMessage = "Wybrano: " + SelectedFruit;
        }

        private void Button_Clicked_New_Fruit(object sender, EventArgs e)
        {
            FruitsCollection.Add(NewFruit);
        }
    }

}
