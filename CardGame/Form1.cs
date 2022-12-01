using CardGame.Assets;
using CardGame.Assets.Model.Cards;
using CardGame.Assets.Models;


namespace CardGame
{

    public partial class Form1 : Form
    {
        private Dictionary<string, Player> Players = new Dictionary<string, Player>()
        {
            { "P1", new Player(BattleStatus.ATTACK) },
            { "P2", new Player(BattleStatus.PROTECTION) },
        };
        string[] PlayerComponents = { "HandDeck", "HeroesOnField", "battlegroundButton", "HandDeckButton", "HeroesOnFieldButton" };

        public Form1()
        {
            InitializeComponent();

            if (File.Exists("Players.json"))
            {
                Players = Serialization.deserialize<Dictionary<string, Player>>("Players");
                foreach (var player in Players)
                {
                    RerenderList((ComboBox)this.Controls["HeroesOnField" + player.Key], player.Value.Deck.OnField);
                    RerenderList((ComboBox)this.Controls["battleground" + player.Key], player.Value.Deck.OnBattleground);
                    if (player.Value.Move == true)
                        ChangeTurnOut(PlayerComponents, Players, 
                        player.Value.BattleStatus == BattleStatus.ATTACK ? BattleStatus.PROTECTION : BattleStatus.ATTACK);
                }
            }
            else
            {
                Game.Start(Players);
                ChangeTurnOut(PlayerComponents, Players, BattleStatus.ATTACK);
            }
            if (File.Exists("Round.json"))
                Game.CurrentRound = Serialization.deserialize<int>("Round");

            foreach (var player in Players)
                RerenderList((ComboBox)this.Controls["HandDeck" + player.Key], player.Value.Deck.OnHand);
            ChangeTextRoundСounter($"Раунд {Game.CurrentRound}");
            RenderPlayersData(Players);

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
            SelectedIndexChanged(HandDeck, "HandDeck", Players[keyPlayer].IsDropOnField(selectedItemHandDeck));
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

            player.Mana -= selectedItemHandDeck.Cost;
            RenderPlayersData(Players);
            player.Deck.OnHand.Remove(selectedItemHandDeck);
            player.Deck.OnField.Add(selectedItemHandDeck);

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
            Players[keyPlayer].Deck.OnField.Remove(selectedItemHeroesOnField.Value);
            Players[keyPlayer].Deck.OnBattleground.Add(selectedItemHeroesOnField.Value);
        }
        private void battlegroundButton_Click(object sender, EventArgs e)
        {
            Button? attackButton = sender as Button;

            string keyPlayer = attackButton.Name.Replace("battlegroundButton", "");
            var player = Players[keyPlayer];
            Players[keyPlayer].Move = true;
            if (player.BattleStatus == BattleStatus.ATTACK)
            {
                ChangeTurnOut(PlayerComponents, Players, BattleStatus.PROTECTION);
                attackButton.Enabled = false;
            }
            else
            {
                if (Fight.start(Players) == null)
                    MessageBox.Show("END");
                
                ChangeTextRoundСounter($"Раунд {Game.CurrentRound}");
                RenderPlayersData(Players); // Обновляем данные игроков
                
                //Переносим карты победителя на персональное поле
                foreach (var Player in Players)
                {
                    RerenderList((ComboBox)this.Controls["HeroesOnField" + Player.Key], Player.Value.Deck.OnBattleground);
                    foreach (var card in Player.Value.Deck.OnBattleground)
                        Player.Value.Deck.OnField.Add(card);
                    Player.Value.Deck.OnBattleground.Clear();
                    Player.Value.Move = false;
                }
                ClearBattleground();
                Game.ChangeBattleStatus(Players);// Меняем боевые статусы игроков
                ChangeTurnOut(PlayerComponents, Players, BattleStatus.ATTACK); // Смена хода игрока
            }
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
        private void ChangeTurnOut(string[] componentNames, Dictionary<string, Player> players, BattleStatus turnOrder)
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
        public void ClearBattleground()
        {
            foreach (var player in Players)
            {
                ComboBox component = (ComboBox)this.Controls["battleground" + player.Key];
                component.Items.Clear();
                component.ResetText();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialization.serialize<int>(Game.CurrentRound, "Round");
            Serialization.serialize<Dictionary<string, Player>>(Players, "Players");
        }
    }
}