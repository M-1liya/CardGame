using CardGame.Assets;
using CardGame.Assets.nsDeck;
using System.Security.Cryptography.Pkcs;

namespace CardGame
{
    public partial class Form1 : Form
    {
        /*private Player P1 = new Player();
        private Player P2 = new Player();*/
        private Dictionary<string, Player> Players = new Dictionary<string, Player>()
        {
            { "P1", new Player() },
            { "P2", new Player() },
        };
    private Game game = new Game();
        public Deck decks = new Deck();
        public Form1()
        {
            InitializeComponent();

            game.Start(Players["P1"], Players["P2"]);
            Round�ounter.Text = $"����� {game.getCurrentRound.ToString()}"; 

            // ����� ������� �����
            foreach(Card card in Players["P1"].handCard)
                HandDeckP1.Items.Add(card.ToString());

            foreach (Card card in Players["P2"].handCard)
                HandDeckP2.Items.Add(card.ToString());
        }

        public void RerenderList(ComboBox comboBox, Player P)
        {
            comboBox.Items.Clear();

            foreach (Card card in P.handCard)   //���������� ��� �����, � ������� � ��-�� �� �����
            {

                if (card.GetTypeCard == Card.TypeCard.Hero)
                {
                    Hero hero = (Hero)card;
                    comboBox.Items.Add(hero.ToString());
                }
                else if (card.GetTypeCard == Card.TypeCard.Potion)
                {
                    Potion potion = (Potion)card;
                    comboBox.Items.Add(potion.ToString());
                }

            }

        }
  
        private void HandDeck_TextChanged(object sender, EventArgs e)
        {
            ComboBox? HandDeck = sender as ComboBox;
            string keyPlayer = HandDeck.Name.Replace("HandDeck", "");
            var DropOnTheFieldButton = this.Controls["DropOnTheFieldButton" + keyPlayer];

            foreach (Card card in Players[keyPlayer].handCard)
                if (HandDeck.SelectedItem.ToString() == card.ToString())
                    DropOnTheFieldButton.Enabled = (card is Potion) ? false : true;

        }
        private void DropOnTheFieldButton_Click(object sender, EventArgs e)
        {
            Button? DropOnTheField = sender as Button;
            string? keyPlayer = DropOnTheField.Name.Replace("DropOnTheFieldButton", "");

            var DropOnTheFieldButton = this.Controls["DropOnTheFieldButton" + keyPlayer];
            var HandDeck = this.Controls["HandDeck" + keyPlayer];
            var HeroesOnTheField = this.Controls["HeroesOnTheField" + keyPlayer];

            
            foreach (Card card in Players[keyPlayer].handCard)
            {
                    if (((ComboBox)HandDeck).SelectedItem.ToString() == card.ToString())
                    {
                        Players[keyPlayer].handCard.Remove(card);
                        break;
                    }

            }
            ((ComboBox)HeroesOnTheField).Items.Add(((ComboBox)HandDeck).SelectedItem.ToString());       //
            RerenderList((ComboBox)HandDeck, Players[keyPlayer]);                                      //
            ((ComboBox)HeroesOnTheField).SelectedItem = ((ComboBox)HeroesOnTheField).Items[0];          //����� � ��� ������
            ((ComboBox)HandDeck).SelectedItem = ((ComboBox)HandDeck).Items[0];
        }

    }
}