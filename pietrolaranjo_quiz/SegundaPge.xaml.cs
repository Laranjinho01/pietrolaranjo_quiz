namespace pietrolaranjo_quiz;

public partial class SegundaPge : ContentPage
{
	public SegundaPge()
	{
		InitializeComponent();
	}

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        if (radioButtonC.IsChecked)
        {
            ScoreStore.Points = ScoreStore.Points + 1;
            await DisplayAlert("Parabens!", "Você acertou. Sua pontuação é: " + ScoreStore.Points + "/10", "Ok");
        }
        else
        {
            await DisplayAlert("Que pena!", "Você errou. Sua pontuação é: " + ScoreStore.Points + "/10 \nResposta: 1500", "Ok");
        }
        await Navigation.PushAsync(new TerceiraPae());
        radioButtonA.IsEnabled = false;
        radioButtonB.IsEnabled = false;
        radioButtonC.IsEnabled = false;
        radioButtonD.IsEnabled = false;
    }
}