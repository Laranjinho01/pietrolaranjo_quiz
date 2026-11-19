namespace pietrolaranjo_quiz;

public partial class OitavaPage : ContentPage
{
	public OitavaPage()
	{
		InitializeComponent();
	}

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        if (radioButtonA.IsChecked)
        {
            ScoreStore.Points = ScoreStore.Points + 1;
            await DisplayAlert("Parabens!", "Você acertou. Sua pontuação é: " + ScoreStore.Points + "/10", "Ok");
        }
        else
        {
            await DisplayAlert("Que pena!", "Você errou. Sua pontuação é: " + ScoreStore.Points + "/10", "Ok");
        }
        await Navigation.PushAsync(new NonaPage());
    }
}