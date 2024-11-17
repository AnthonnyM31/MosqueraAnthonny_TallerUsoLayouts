namespace MosqueraAnthonny_TallerUsoLayouts;

public partial class AbsoluteLayoutPage : ContentPage
{
    public AbsoluteLayoutPage()
    {
        InitializeComponent();
    }

    private async void GoToGridLayout(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}
