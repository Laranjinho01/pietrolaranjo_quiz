namespace pietrolaranjo_quiz;

public partial class TerceiraPae : ContentPage
{
	public TerceiraPae()
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
            await DisplayAlert("Que pena!", "Você errou. Sua pontuação é: " + ScoreStore.Points + "/10 \nResposta: Um movimento intelectual que defendia a razão, a liberdade e a igualdade.", "Ok");
        }
        await Navigation.PushAsync(new QuartaPage());
        radioButtonA.IsEnabled = false;
        radioButtonB.IsEnabled = false;
        radioButtonC.IsEnabled = false;
        radioButtonD.IsEnabled = false;
        
    }
}