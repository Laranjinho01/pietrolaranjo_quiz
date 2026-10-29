

namespace pietrolaranjo_quiz;

public partial class PrimeiraPage : ContentPage
{
	public PrimeiraPage()
	{
		InitializeComponent();
	}

    private void OnEnviarClicked(object sender, EventArgs e)
    {
        if (radioButtonA.IsChecked)
        {
            ScoreStore.Points += ScoreStore.Points;
            DisplayAlert.Show("Parabens","Você acertou. Sua pontuação é: " + ScoreStore.Points + "/10","Ok");
        }
       
        
    }
}