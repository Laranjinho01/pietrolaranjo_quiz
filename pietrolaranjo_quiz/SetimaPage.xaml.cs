namespace pietrolaranjo_quiz;

public partial class SetimaPage : ContentPage
{
	public SetimaPage()
	{
		InitializeComponent();
	}

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        if (radioButtonB.IsChecked)
        {
            ScoreStore.Points = ScoreStore.Points + 1;
            await DisplayAlert("Parabens!", "Você acertou. Sua pontuação é: " + ScoreStore.Points + "/10", "Ok");
        }
        else
        {
            await DisplayAlert("Que pena!", "Você errou. Sua pontuação é: " + ScoreStore.Points + "/10 \nResposta: A mudança da produção manual para a produção com máquinas.", "Ok");
        }
        await Navigation.PushAsync(new OitavaPage());
        radioButtonA.IsEnabled = false;
        radioButtonB.IsEnabled = false;
        radioButtonC.IsEnabled = false;
        radioButtonD.IsEnabled = false;
    }
}