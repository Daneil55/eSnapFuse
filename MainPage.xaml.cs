
using System.Threading.Tasks;

namespace eSnapFuse
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

       
        private async void Profile_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Found", "Not Found", "Ok");
            Navigation.PushAsync(new StarterPage());
        }
    }
}
