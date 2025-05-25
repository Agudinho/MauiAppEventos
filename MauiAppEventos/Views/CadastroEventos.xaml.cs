using System.Runtime.CompilerServices;
using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class CadastroEventos : ContentPage
{
	public CadastroEventos()
	{
		InitializeComponent();

        inicio.MinimumDate = DateTime.Now;
        inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        termino.MinimumDate = inicio.Date.AddDays(1);
        termino.MaximumDate = inicio.Date.AddMonths(6);
	}

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        if (termino.Date < inicio.Date)
        {
            await DisplayAlert("Erro", "A data de t�rmino n�o pode ser anterior � data de in�cio.", "OK");
            return;
        }

        var evento = new Evento
        {
            Nome = nome.Text,
            Inicio = inicio.Date,
            Termino = termino.Date,
            Participantes = (int)stp_part.Value,
            Local = local.Text,
            Custo = double.TryParse(custo.Text, out var valor) ? valor : 0
        };

        try
        {
            await Navigation.PushAsync(new InformacoesEventos(evento));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Voltar");
        } 
        
        

    }

    private void termino_DateSelected(object sender, DateChangedEventArgs e)
    {
        termino.MinimumDate = inicio.Date;
        termino.MaximumDate = inicio.Date.AddMonths(2);

        // Valida a sele��o
        if (termino.Date < inicio.Date)
        {
            DisplayAlert("Data inv�lida", "A data de t�rmino n�o pode ser antes da data de in�cio.", "OK");
            termino.Date = inicio.Date;
        }

    }
}