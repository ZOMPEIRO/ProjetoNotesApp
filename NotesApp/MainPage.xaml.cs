using System.Reflection.Metadata;

namespace NotesApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ConuterBtn_Clicked(object sender, EventArgs e)
        {
            //Pegar nome digitado

            string nome = NomeEntry.Text;


            //Armazenar nome digitado;

            //Exibir nome digitado em uma cx de texto


        }

        private void OiButton_Clicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            NomeLabel.Text = $"oi, {nome}"; 
        }
    }

}
