

namespace eSnapFuse.Pages;

public partial class Rooms : ContentPage
{
    public Rooms()
    {
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("BOOKINGS ", "Bookings", "Close");

    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {

        DisplayAlert("HOME ", "Home", "Close");
        Navigation.PushAsync(new MainPage());
    }

    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
  
    }

    private void TapGestureRecognizer_Tapped_3(object sender, TappedEventArgs e)
    {
        DisplayAlert("PROFILE ", "Profile page", "Close");
        Navigation.PushAsync(new Settings());
    }

    private void TapGestureRecognizer_Tapped_4(object sender, TappedEventArgs e)
    {

        Navigation.PushAsync(new Messagelist());
    }
}