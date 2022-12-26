using CardGame.Assets;
using CardGame.Assets.Model;
using CardGame.Assets.Model.Cards;


namespace CardGame
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Player> Players = new Dictionary<string, Player>()
        {
            { "P1", new Player(BattleStatus.ATTACK) },
            { "P2", new Player(BattleStatus.PROTECTION) },
        };
        string[] PlayerComponents = { "HandDeck", "HeroesOnField", "battlegroundButton", "HandDeckButton" };

        public Form1()
        {
            InitializeComponent();

            ChangeTurnOut(PlayerComponents, Players, BattleStatus.ATTACK);
            if (File.Exists("Players.json") && File.Exists("Round.json"))
            {
                Players = Serialization.deserialize<Dictionary<string, Player>>(new FileInfo("Players.json"));
                Game.CurrentRound = Serialization.deserialize<int>(new FileInfo("Round.json"));

                foreach (var player in Players)
                    if (player.Value.Move == true)
                        ChangeTurnOut(PlayerComponents, Players,
                                player.Value.BattleStatus == BattleStatus.ATTACK ? BattleStatus.PROTECTION : BattleStatus.ATTACK);
            }
            else
                Game.Start(Players);

            foreach (var Player in Players)
            {
                RerenderList((ComboBox)this.Controls["HandDeck" + Player.Key], Player.Value.Deck.OnHand, true);
                RerenderList((ComboBox)this.Controls["HeroesOnField" + Player.Key], Player.Value.Deck.OnField, true);
                RerenderList((ComboBox)this.Controls["Battleground" + Player.Key], Player.Value.Deck.OnBattleground, true);
            }

            ChangeTextRound�ounter($"����� {Game.CurrentRound}");
            RenderPlayersData(Players);

        }
        /// <summary>
        /// <para>
        /// ���� ����� ������� ComboBox, ������� ��� �������� �
        /// ��������� � ���� ������� ���� (�����, ��������) �� Player.getHandCard
        /// </para>
        /// <see href="https://stackoverflow.com/questions/3063320/combobox-adding-text-and-value-to-an-item-no-binding-source">��� ������������ ����� ���������� Stackoverflow �� ������� �������</see>
        /// </summary>
        /// <param name="comboBox">CommandBox, ������� ����� ������������</param>
        /// <param name="comboBox">�����, ������� ������ HandCard</param>
        private void RerenderList(ComboBox comboBox, List<Card> cards, bool isClear = false)
        {
            if (isClear)
                comboBox.Items.Clear();

            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
            foreach (Card card in cards)
                comboBox.Items.Add(new {Text = card.ToString(), Value = card } );
        }
        /// <summary>
        /// <para>
        /// ���� ����� ���������� ������� �� ������ combobox � ������
        /// </para>
        /// </summary>
        /// <param name="componentOut">������ ����������</param>
        /// <param name="componentIn">���� ����������</param>
        /// <param name="item">������� �����, ������� ����������</param>
        /// 
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
        /// <summary>
        /// ��������� ������� ������������ Label, Image, ������� �� �������
        /// </summary>
        /// <param name="players">������� �������</param>
        public void RenderPlayersData(Dictionary<string, Player> players)
        {
            foreach (var player in players)
            {
                this.Controls["amountHealtNexus" + player.Key].Text = player.Value.HealthNexus.ToString();
                this.Controls["amountMana" + player.Key].Text = player.Value.Mana.ToString();

                ((PictureBox)this.Controls["BattleStatus" + player.Key]).Image = Image.FromFile(@$"../../../images/{player.Value.BattleStatus.ToString()}.png");

            }
        }


        /// <summary>
        /// ��������� ��������� �� ��� ���� ������ ������� �������������� �����
        /// </summary>
        private void HandDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? HandDeck = sender as ComboBox;
            string keyPlayer = HandDeck.Name.Replace("HandDeck", "");
            Card selectedItemHandDeck;
            if (HandDeck.SelectedItem as dynamic != null)
            {
                selectedItemHandDeck = (HandDeck.SelectedItem as dynamic).Value; // <=> HandDeck.selectedItem
                SelectedIndexChanged(HandDeck, "HandDeck", Players[keyPlayer].IsCanPutCard(selectedItemHandDeck));
            }
        }
        /// <summary>
        /// ��������� ��������� �� ��� ���� ������ ������� �������������� �����
        /// </summary>
        private void HeroesOnField_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? HeroesOnField = sender as ComboBox;
            SelectedIndexChanged(HeroesOnField, "HeroesOnField");
        }
        /// <summary>
        /// �������� enable ������ ������
        /// </summary>
        /// <param name="component">���������, � ������� ����� ������ �����</param>
        /// <param name="nameComponent">�������� ���������� ��� ������� ������</param>
        /// <param name="enable">enable ����������</param>
        private void SelectedIndexChanged(ComboBox component, string nameComponent, bool enable = true)
        {
            string keyPlayer = component.Name.Replace(nameComponent, "");
            var button = this.Controls[nameComponent + "Button" + keyPlayer];
            button.Enabled = enable;
        }


        /// <summary>
        /// ��������� ����� ������ �� combobox OnHand � OnDeck
        /// </summary>
        private void HandDeckButton_Click(object sender, EventArgs e)
        {
            Button? DropOnField = sender as Button; // ������ � ������� ��������� ����

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
        /// <summary>
        /// ��������� ����� ������ �� combobox OnDeck � OnButtleGround
        /// </summary>
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
        /// <summary>
        /// ������ �����
        /// </summary>
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
                var res = Fight.Start(Players.Values.ToList());
                if (res != null)
                    for (int i = 0; i < res.Count; i++)
                        Players["P" + (i + 1)] = res[i];
                else
                {
                    MessageBox.Show("��������� ����� ������� ������!");

                    string[] FilesName = { "Players.json", "Round.json" };
                    foreach (var fileName in FilesName)
                        if (File.Exists(fileName))
                            File.Delete(fileName);

                    Menu menu = new Menu();
                    menu.ShowDialog();
                    this.Close();
                }

                ChangeTextRound�ounter($"����� {Game.CurrentRound}");

                //��������� ����� ���������� �� ������������ ����
                foreach (var Player in Players)
                {
                    RerenderList((ComboBox)this.Controls["HeroesOnField" + Player.Key], Player.Value.Deck.OnBattleground);
                    foreach (var card in Player.Value.Deck.OnBattleground)
                        Player.Value.Deck.OnField.Add(card);
                    Player.Value.Deck.OnBattleground.Clear();
                    Player.Value.Move = false;
                }

                //��������� ����� �� ������������ ����
                foreach (var Player in Players)
                {
                    RerenderList((ComboBox)this.Controls["HandDeck" + Player.Key], Player.Value.Deck.OnHand, true);
                    RerenderList((ComboBox)this.Controls["HeroesOnField" + Player.Key], Player.Value.Deck.OnField, true);
                    RerenderList((ComboBox)this.Controls["Battleground" + Player.Key], Player.Value.Deck.OnBattleground, true);
                }
                ClearBattleground();
                Game.ChangeBattleStatus(Players.Values.ToList());// ������ ������ ������� �������
                RenderPlayersData(Players); // ��������� ������ �������
                ChangeTurnOut(PlayerComponents, Players, BattleStatus.ATTACK); // ����� ���� ������
            }
        }

        /// <summary>
        /// ����������� �� ���� ����������� enable
        /// </summary>
        /// <param name="componentsNames">������� ����������� ������</param>
        /// <param name="enable">�������� Enable</param>
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
                    MessageBox.Show($"���������� � ������: {componentName} �� ����������");
                }
            }
        }
        /// <summary>
        /// ��������� ������� �������� � ����� name ������ str
        /// </summary>
        /// <param name="componentsNames">������� ����������� ������</param>
        /// <param name="str">������, ������� ������� �������� � �����</param>
        /// <returns>���������� ����� componentsNames</returns>
        private string[] AppendStringInLast(string[] componentNames, string str)
        {
            string[]? cloneComponentNames = componentNames.Clone() as string[];

            for (int i = 0; i < cloneComponentNames.Length; i++)
                cloneComponentNames[i] += str;
            return cloneComponentNames;
        }
        /// <summary>
        /// ������������� �������� enable ����������� ������� �� �� BattleStatus
        /// </summary>
        /// <param name="componentsNames">������� ����������� ������</param>
        /// <param name="players">������� �������</param>
        /// <param name="turnOrder">������� ����� �����</param>
        private void ChangeTurnOut(string[] componentNames, Dictionary<string, Player> players, BattleStatus turnOrder)
        {
            foreach (var player in players)
            {
                bool enable = (player.Value.BattleStatus == turnOrder) ? true : false;
                EnableComponents(AppendStringInLast(componentNames, player.Key), enable);
            }
        }
        

        /// <summary>
        /// �������� ����� label - ������� �����
        /// </summary>
        /// <param name="text">������, ������� ������ RoundCounter</param>
        public void ChangeTextRound�ounter(string text)
        {
            Round�ounter.Text = text;
        }
        /// <summary>
        /// ������� combobox(battleground) ������� 
        /// </summary>
        public void ClearBattleground()
        {
            foreach (var player in Players)
            {
                ComboBox component = (ComboBox)this.Controls["battleground" + player.Key];
                component.Items.Clear();
                component.ResetText();
            }
        }
        /// <summary>
        /// ��������� ������� ����� ������ �� ����
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialization.serialize<int>(Game.CurrentRound, new FileInfo("Round.json"));
            Serialization.serialize<Dictionary<string, Player>>(Players, new FileInfo("Players.json"));
        }
    }
}