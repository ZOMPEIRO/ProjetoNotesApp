namespace NotesApp;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

    private void BotãoPerfil_Clicked(object sender, EventArgs e)
    {
		Uri link = new Uri("https://github.com/ZOMPEIRO");
        Launcher.OpenAsync(link);
    }
}