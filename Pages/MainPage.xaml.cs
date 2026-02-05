using eSnapFuse.Pages;

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
            await DisplayAlert("Found", "Booking found", "Ok");

        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            //Navigate to the MainPage
            Navigation.PushAsync(new MainPage());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            Navigation.PushAsync(new Rooms());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_3(object sender, TappedEventArgs e)
        {

        }
    }
}
