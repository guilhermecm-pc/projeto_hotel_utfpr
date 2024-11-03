using HotelProgram.Modelo;
using HotelProgram.RepositorioDoHotel;
using System.Globalization;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       private void OnCadastrarClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string cpf = CPFEntry.Text;
            string dataNascimento = DataNascimentoEntry.Text;
         
            string endereco = EnderecoEntry.Text;
            int numeroQuarto;

            if (!int.TryParse(NumeroQuartoEntry.Text, out numeroQuarto))
            {
                DisplayAlert("Erro", "Número do quarto deve ser um número.", "OK");
                return;
            }

            var hospede = new Hospede(nome, cpf, dataNascimento, endereco, numeroQuarto);
            RepositorioDeHospedes novo = new RepositorioDeHospedes();
            novo.Cadastrar(hospede);
            DisplayAlert("Sucesso", "Hóspede cadastrado com sucesso!", "OK");

        }
    }

}
