using MauiAppEventos.Models;
using Microsoft.Extensions.Logging;
namespace MauiAppEventos.Views;

public partial class InformacoesEventos : ContentPage
{
	public InformacoesEventos(Evento evento)
    {
        InitializeComponent();

        BindingContext = evento;
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}