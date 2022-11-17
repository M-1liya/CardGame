using CardGame.Assets;
using CardGame.Assets.nsDeck;
using System.Security.Cryptography.Pkcs;

namespace CardGame
{
    public partial class Form1 : Form
    {
        private Player P1 = new Player();
        private Player P2 = new Player();
        private Game game = new Game();
        public Deck decks = new Deck();
        private List<Card> cardsListComboBoxInHandP1 = new List<Card>();
        private List<Card> cardsListComboBoxInHandP2 = new List<Card>();
        public Form1()
        {
            InitializeComponent();

            game.Start(P1, P2);
            Round—ounter.Text = $"–‡ÛÌ‰ {game.currentRound}";
            game.SetStartCard(P1, HandDeckP1, cardsListComboBoxInHandP1);
            game.SetStartCard(P2, HandDeckP2, cardsListComboBoxInHandP2);
        }

        private void HandDeckP1_TextChanged(object sender, EventArgs e)
        {
            foreach (Card card in P1.handCard)
            {
                if (card == cardsListComboBoxInHandP1[HandDeckP1.SelectedIndex])
                {
                    if(card is Hero)
                    {
                        DropOnTheFieldButtonP1.Visible = true;
                    }
                    else
                    {
                        DropOnTheFieldButtonP1.Visible = false;
                    }
                }
            }
        }

        private void DropOnTheFieldButtonP1_Click(object sender, EventArgs e)
        {
            foreach (Card card in P1.handCard)
            {
                if (card == cardsListComboBoxInHandP1[HandDeckP1.SelectedIndex])
                {
                    cardsListComboBoxInHandP1.Remove(cardsListComboBoxInHandP1[HandDeckP1.SelectedIndex]);
                    P1.handCard.Remove(card);
                    break;
                }  
            }
            HeroesOnTheFieldP1.Items.Add(HandDeckP1.SelectedItem.ToString());
            game.RenderList(HandDeckP1, cardsListComboBoxInHandP1);
            HeroesOnTheFieldP1.SelectedItem = HeroesOnTheFieldP1.Items[0];
            DropOnTheFieldButtonP1.Visible = false;
        }
    }
}