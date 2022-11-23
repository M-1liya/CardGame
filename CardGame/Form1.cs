using CardGame.Assets;
using CardGame.Assets.nsDeck;
using CardGame.Tests;
using System.Security.Cryptography.Pkcs;

namespace CardGame
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Player> Players = new Dictionary<string, Player>()
        {
            { "P1", new Player(Player.EBattleStatus.Attack) },
            { "P2", new Player(Player.EBattleStatus.Protection) },
        };
        private Game game = new Game();
        private Deck decks = new Deck();
        string[] PlayerComponents = { "HandDeck", "HeroesOnField" };

        public Form1()
        {
            InitializeComponent();


            game.Start(Players);
            ChangeTextRoundСounter($"Раунд {game.CurrentRound}");
            RenderPlayersData(Players);
            EnableComponentsForTurnOrderPlayer(PlayerComponents, game, Players, Player.EBattleStatus.Attack);

            foreach (var player in Players)
                RerenderList((ComboBox)this.Controls["HandDeck" + player.Key], player.Value.HandCard);


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
        private void RerenderList(ComboBox comboBox, List<Card> cards)
        {
            //comboBox.Items.Clear();
            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
            foreach (Card card in cards)
                comboBox.Items.Add(new {Text = card.ToString(), Value = card } );
        }
        private void transferItem(ComboBox componentOut, ComboBox componentIn, Card item)
        {
            ComboBox[] components = { componentOut, componentIn };
            componentOut.Items.Remove(new { Text = item.ToString(), Value = item });
            RerenderList(componentIn, new List<Card> { item } );
            foreach (var component in components)
            {
                if (component.Items.Count > 0)
                    component.SelectedItem = component.Items[0];
                else
                    component.ResetText();
            }

        }
        public void RenderPlayersData(Dictionary<string, Player> players)
        {
            foreach (var player in players)
            {
                this.Controls["amountHealtNexus" + player.Key].Text = player.Value.HealthNexus.ToString();
                this.Controls["amountMana" + player.Key].Text = player.Value.Mana.ToString();
            }
        }
        
        
        private void HandDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? HandDeck = sender as ComboBox;
            string keyPlayer = HandDeck.Name.Replace("HandDeck", "");
            var selectedItemHandDeck = (HandDeck.SelectedItem as dynamic).Value; // <=> HandDeck.selectedItem
            SelectedIndexChanged(HandDeck, "HandDeck", Players[keyPlayer].DropOnField(selectedItemHandDeck));
        }
        private void HeroesOnField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? HeroesOnField = sender as ComboBox;
            SelectedIndexChanged(HeroesOnField, "HeroesOnField");
        }
        private void SelectedIndexChanged(ComboBox component, string nameComponent, bool enable = true)
        {
            string keyPlayer = component.Name.Replace(nameComponent, "");
            var button = this.Controls[nameComponent + "Button" + keyPlayer];
            button.Enabled = enable;
        }
        
        private void HandDeckButton_Click(object sender, EventArgs e)
        {
            Button? DropOnField = sender as Button; // Кнопка с которой произошёл клик

            string? keyPlayer = DropOnField.Name.Replace("HandDeckButton", "");
            var HandDeck = (ComboBox)this.Controls["HandDeck" + keyPlayer];
            var HeroesOnField = (ComboBox)this.Controls["HeroesOnField" + keyPlayer];
            var selectedItemHandDeck = (HandDeck.SelectedItem as dynamic).Value;
            var player = Players[keyPlayer];

            //game.resetTurnOrder(Players.Count);
            //EnableComponentsForTurnOrderPlayer(PlayerComponents, game, Players);
            RenderPlayersData(Players);
            player.removeHandCard(selectedItemHandDeck); //Убрали выбранную карту
            transferItem(HandDeck, HeroesOnField, selectedItemHandDeck);
            
        }
        private void HeroesOnFieldButton_Click(object sender, EventArgs e)
        {
            Button? attackButton = sender as Button;

            string keyPlayer = attackButton.Name.Replace("HeroesOnFieldButton", "");
            var HeroesOnField = (ComboBox)this.Controls["HeroesOnField" + keyPlayer];
            var battleground = (ComboBox)this.Controls["battleground" + keyPlayer];
            var selectedItemHeroesOnField = (HeroesOnField.SelectedItem as dynamic);

            attackButton.Enabled = false;
            transferItem(HeroesOnField, battleground, selectedItemHeroesOnField.Value);
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
        private string[] AppendStringInLast(string[] componentNames, string str)
        {
            string[]? cloneComponentNames = componentNames.Clone() as string[];

            for (int i = 0; i < cloneComponentNames.Length; i++)
                cloneComponentNames[i] += str;
            return cloneComponentNames;
        }
        private void EnableComponentsForTurnOrderPlayer(string[] componentNames, Game game, Dictionary<string, Player> players, Player.EBattleStatus turnOrder)
        {
            foreach (var player in players)
            {
                bool enable = (player.Value.BattleStatus == turnOrder) ? true : false;
                EnableComponents(AppendStringInLast(componentNames, player.Key), enable);
            }
        }
        public void ChangeTextRoundСounter(string text)
        {
            RoundСounter.Text = text;
        }

        private void battlegroundButtonP1_Click(object sender, EventArgs e)
        {
            Button? attackButton = sender as Button;

            string keyPlayer = attackButton.Name.Replace("battlegroundButton", "");
            var player = Players[keyPlayer];
            if (player.BattleStatus == Player.EBattleStatus.Attack)
            {
                EnableComponentsForTurnOrderPlayer(PlayerComponents, game, Players, Player.EBattleStatus.Protection);
                attackButton.Enabled = false;
            }

        }
    }
}