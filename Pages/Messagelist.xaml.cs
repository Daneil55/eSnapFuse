namespace eSnapFuse.Pages;

public partial class Messagelist : ContentPage
{
    public Messagelist()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new Messagepage());
    }
}