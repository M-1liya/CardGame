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
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(z.GetType().ToString());
            game.Start(P1, P2);
            Round—ounter.Text = $"–‡ÛÌ‰ {game.currentRound.ToString()}"; 

            foreach(Card card in P1.handCard)
            {
                HandDeckP1.Items.Add($"{card.cost} {card.name} ¿:{1} HP:{1}");
            }


            foreach (Card card in P2.handCard)
            {
                HandDeckP2.Items.Add($"{card.cost} {card.name} ¿:{1} HP:{1}");
            }
        }

        private void HandDeckP1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(HandDeckP1.SelectedValue.ToString());
            foreach (Card card in P1.handCard)
            {
                if (HandDeckP1.SelectedItem.ToString() == $"{card.cost} {card.name} ¿:{1} HP:{1}")
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
                if (HandDeckP1.SelectedItem.ToString() == $"{card.cost} {card.name} ¿:{1} HP:{1}")
                {
                    P1.handCard.Remove(card);
                    break;
                }
            }
            HeroesOnTheFieldP1.Items.Add(HandDeckP1.SelectedItem.ToString());
            game.RerenderList(HandDeckP1, P1);
            HeroesOnTheFieldP1.SelectedItem = HeroesOnTheFieldP1.Items[0];
            DropOnTheFieldButtonP1.Visible = false;
        }
    }
}