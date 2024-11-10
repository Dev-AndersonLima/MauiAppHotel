namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Sobre());

        } catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        try
        {
           await Navigation.PushAsync(new HospedagemContratada());

        } catch(Exception ex)
        {
           await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}