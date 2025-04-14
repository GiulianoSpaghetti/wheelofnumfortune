namespace wheelofnumfortune;

public partial class InfoPage : ContentPage
{
    public static readonly Uri uri = new Uri("https://github.com/GiulianoSpaghetti/WheelOfNumFortune");

    public InfoPage()
	{
		InitializeComponent();
	}

    private async void OnSito_Click(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync(uri);
    }
}