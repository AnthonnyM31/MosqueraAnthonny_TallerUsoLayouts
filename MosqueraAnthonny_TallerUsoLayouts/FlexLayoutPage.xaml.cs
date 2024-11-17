namespace MosqueraAnthonny_TallerUsoLayouts;

public partial class FlexLayoutPage : ContentPage
{
    public FlexLayoutPage()
    {
        InitializeComponent();
    }

    private async void GoToAbsoluteLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayoutPage());
    }

    private async void OnImageTapped(object sender, EventArgs e)
    {
        if (sender is Image image && image.BindingContext is string imageName)
        {
            await DisplayAlert("Imagen Tapped", $"Has tocado: {imageName}", "OK");
            await Navigation.PushAsync(new AbsoluteLayoutPage());
        }
    }
}
