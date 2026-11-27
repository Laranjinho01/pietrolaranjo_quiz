namespace pietrolaranjo_quiz;

public partial class SextaPage : ContentPage
{
	public SextaPage()
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
            await DisplayAlert("Que pena!", "Você errou. Sua pontuação é: " + ScoreStore.Points + "/10 \nResposta: O desejo de conquistar autonomia política.", "Ok");
        }
        await Navigation.PushAsync(new SetimaPage());
        radioButtonA.IsEnabled = false;
        radioButtonB.IsEnabled = false;
        radioButtonC.IsEnabled = false;
        radioButtonD.IsEnabled = false;
    }
}