namespace pietrolaranjo_quiz;

public partial class DecimaPage : ContentPage
{
	public DecimaPage()
	{
		InitializeComponent();
	}

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        if (radioButtonD.IsChecked)
        {
            ScoreStore.Points = ScoreStore.Points + 1;
            await DisplayAlert("Parabens!", "Você acertou. Sua pontuação final foi: " + ScoreStore.Points + "/10", "Ok");
        }
        else
        {
            await DisplayAlert("Que pena!", "Você errou. Sua pontuação final foi: " + ScoreStore.Points + "/10", "Ok");
        }
        await Navigation.PushAsync(new MainPage());
    }
}