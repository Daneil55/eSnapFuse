
using eSnapFuse.Models;
using eSnapFuse.Pages;
using System.Threading.Tasks;

namespace eSnapFuse
{
    public partial class MainPage : ContentPage
    {
       

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
            //await DisplayAlert("Found", "Not Found", "Ok");
            await Navigation.PushAsync(new Rooms());
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            
        }

        private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {

        }
    }
}
