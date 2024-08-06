using PickRandomCards;

namespace PickRandomCardsMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void PickCardsButton_clicked(object sender, EventArgs e)
	{
        if (int.TryParse(NumberOfCards.Text, out int numberOfCards))
        {
			PickedCards.Text = string.Empty;
            string[] cards = CardPicker.PickSomeCards(numberOfCards);
            foreach (string card in cards)
            {
                PickedCards.Text += card + Environment.NewLine;
            }
			PickedCards.Text += Environment.NewLine + "You picked " + numberOfCards + " cards."; 
        }
        else
        {
            PickedCards.Text = "Please enter a valid number.";
        }
	}
}

