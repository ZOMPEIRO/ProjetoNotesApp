namespace NotesApp;

public partial class Notepad : ContentPage
{

    string fileName = Path.Combine(FileSystem.AppDataDirectory, "config.DAT");
    public Notepad()
    {
        InitializeComponent();

        if (File.Exists(fileName))
            TextEditor.Text = File.ReadAllText(fileName);
    }

    private void SalvarButton_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(fileName, TextEditor.Text);
    }

    private void DeletarButton_Clicked(object sender, EventArgs e)
    {
        string fileName = Path.Combine(FileSystem.AppDataDirectory, "config.DAT");
        File.Delete(fileName);

    }
}