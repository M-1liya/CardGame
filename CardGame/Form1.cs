using CardGame.Assets;
using CardGame.Assets.nsDeck;

namespace CardGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Player P1 = new Player();
            Player P2 = new Player();
            Game game = new Game();
            game.Start(P1, P2);
            Round—ounter.Text = $"–‡ÛÌ‰ {game.currentRound.ToString()}"; 
            foreach(Card card in P1.handCard)
            {
                HandDeckP1.Items.Add($"{card.name}");
            }
            foreach (Card card in P2.handCard)
            {
                HandDeckP2.Items.Add($"{card.name}");
            }
        }
    }
}