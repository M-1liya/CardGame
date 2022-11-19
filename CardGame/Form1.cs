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
        string[] PlayerComponents = { "HandDeck", "DropOnTheFieldButton", "HeroesOnTheField" };

        public Form1()
        {
            InitializeComponent();

            game.Start(Players);
            RoundСounter.Text = $"Раунд {game.getCurrentRound.ToString()}";

            foreach (var player in Players)
                RerenderList((ComboBox)this.Controls["HandDeck" + player.Key], player.Value);
            EnableComponentsForTurnOrderPlayer(PlayerComponents, game, Players);
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
        private void RerenderList(ComboBox comboBox, Player player)
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
            if (!selectedItemFromHandDeck.isHero(selectedItemFromHandDeck))
                DropOnTheFieldButton.Text = "Использовать";
            else
                DropOnTheFieldButton.Text = "Вывести на поле";


        }
        private void DropOnTheFieldButton_Click(object sender, EventArgs e)
        {
            Button? DropOnTheField = sender as Button; // Кнопка с которой произошёл клик

            string? keyPlayer = DropOnTheField.Name.Replace("DropOnTheFieldButton", "");
            var HandDeck = (ComboBox)this.Controls["HandDeck" + keyPlayer];
            var HeroesOnTheField = (ComboBox)this.Controls["HeroesOnTheField" + keyPlayer];

            var selectedItemFromHandDeck = (HandDeck.SelectedItem as dynamic).Value;
            var player = Players[keyPlayer];

            game.resetTurnOrder(Players.Count);
            EnableComponentsForTurnOrderPlayer(PlayerComponents, game, Players);
            player.removeHandCard(selectedItemFromHandDeck); //Убрали использованную карту
            HeroesOnTheField.Items.Add(selectedItemFromHandDeck);
            RerenderList(HandDeck, Players[keyPlayer]);
            HeroesOnTheField.SelectedItem = HeroesOnTheField.Items[0];
            HandDeck.SelectedItem = HandDeck.Items[0];
        }
        private void EnableComponents(string[] componentsNames, bool enable)
        {
            foreach (var componentName in componentsNames)
            {
                try
                {
                    this.Controls[componentName].Enabled = enable;
                }
                catch (System.NullReferenceException ex)
                {
                   MessageBox.Show($"Компонента с именем: {componentName} не существует");
                }
            }
        }
        private string[] appendStringInLast(string[] componentNames, string str)
        {
            string[]? cloneComponentNames = componentNames.Clone() as string[];

            for (int i = 0; i < cloneComponentNames.Length; i++)
                cloneComponentNames[i] += str;
            return cloneComponentNames;
        }
        private void EnableComponentsForTurnOrderPlayer(string[] componentNames, Game game, Dictionary<string, Player> players)
        {
            foreach (var player in players)
            {
                bool enable = ("P"+game.getTurnOrder.ToString() == player.Key) ? true : false;
                EnableComponents(appendStringInLast(componentNames, player.Key), enable);
            }
        }


    }
}