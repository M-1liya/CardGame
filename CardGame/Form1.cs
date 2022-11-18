using CardGame.Assets;
using CardGame.Assets.nsDeck;
using System.Security.Cryptography.Pkcs;

namespace CardGame
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Player> Players = new Dictionary<string, Player>()
        {
            { "P1", new Player() },
            { "P2", new Player() },
        };
        private Game game = new Game();
        private Deck decks = new Deck();
        public Form1()
        {
            InitializeComponent();

            game.Start(Players);
            RoundСounter.Text = $"Раунд {game.getCurrentRound.ToString()}";

            foreach (var player in Players)
                RerenderList((ComboBox)this.Controls["HandDeck" + player.Key], player.Value);

        }

        /// <summary>
        /// <para>
        /// Этот метод очищяет ComboBox, который ему передали и
        /// вставляет в него обьекты типа (текст, значение) из Player.getHandCard
        /// </para>
        /// <see href="https://stackoverflow.com/questions/3063320/combobox-adding-text-and-value-to-an-item-no-binding-source">Для ознакомления моэно посмотреть Stackoverflow по данному вопросу</see>
        /// </summary>
        /// <param name="comboBox">CommandBox, который нужно перезаписать</param>
        /// <param name="comboBox">Игрок, который имееет HandCard</param>
        public void RerenderList(ComboBox comboBox, Player player)
        {
            comboBox.Items.Clear();
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
            foreach (Card playerCard in player.getHandCard)
                comboBox.Items.Add(new {Text = playerCard.ToString(), Value = playerCard} );
        }
        private void HandDeck_TextChanged(object sender, EventArgs e)
        {
            ComboBox? HandDeck = sender as ComboBox;
            
            string keyPlayer = HandDeck.Name.Replace("HandDeck", "");
            var DropOnTheFieldButton = this.Controls["DropOnTheFieldButton" + keyPlayer]; 
            var selectedItemFromHandDeck = (HandDeck.SelectedItem as dynamic).Value; // <=> HandDeck.selectedItem
            DropOnTheFieldButton.Enabled = (selectedItemFromHandDeck is Hero) ? true : false;
        }
        private void DropOnTheFieldButton_Click(object sender, EventArgs e)
        {
            Button? DropOnTheField = sender as Button; // Кнопка с которой произошёл клик
            
            string? keyPlayer = DropOnTheField.Name.Replace("DropOnTheFieldButton", "");
            var HandDeck = (ComboBox)this.Controls["HandDeck" + keyPlayer];
            var HeroesOnTheField = (ComboBox)this.Controls["HeroesOnTheField" + keyPlayer];

            var selectedItemFromHandDeck = (HandDeck.SelectedItem as dynamic).Value;
            var player = Players[keyPlayer];
            
            player.removeHandCard(selectedItemFromHandDeck); //Убрали использованную карту
            HeroesOnTheField.Items.Add(selectedItemFromHandDeck);
            RerenderList(HandDeck, Players[keyPlayer]);
            
            HeroesOnTheField.SelectedItem = HeroesOnTheField.Items[0];
            HandDeck.SelectedItem = HandDeck.Items[0];
        }

    }
}