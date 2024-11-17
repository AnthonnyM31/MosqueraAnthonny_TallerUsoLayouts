namespace MosqueraAnthonny_TallerUsoLayouts;

public partial class GridLayoutPage : ContentPage
{
    public GridLayoutPage()
    {
        InitializeComponent();
    }

    private async void GoToStackLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayoutPage());
    }
}
