namespace NotesApp;

public partial class NewPage : ContentPage
{
    string fileName = Path.Combine(FileSystem.AppDataDirectory, "config.DAT");
    public NewPage()
    {
        InitializeComponent();

        if (File.Exists(fileName))
            TextEditor.Text = File.ReadAllText(fileName);
    }

    private void SalveButton_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(fileName, TextEditor.Text);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        string fileName = Path.Combine(FileSystem.AppDataDirectory, "config.DAT");
        File.Delete(fileName);

    }
}