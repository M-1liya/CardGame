using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;
using CardGame.Assets.Models.Cards;
using CardGame.Assets.Model;

namespace CardGame.Assets
{
    public static class Fight
    {
        static Dictionary<BattleStatus, Player?> FightPlayers;

        /// <summary>
        /// В этом методе происходит битва колод OnBattleGround
        /// </summary>
        /// <param name="Players">Словарь игроков</param>
        /// <returns>Cписок игроков после битвы, либо null в случае проигрыша одного из игроков</returns>
        public static List<Player>? Start(List<Player> Players)
        {
            FightPlayers = new Dictionary<BattleStatus, Player?>();

            foreach (var player in Players)
                FightPlayers[player.BattleStatus] = player;
            
            castPotion(Players);

            var DataAttack = new Dictionary < DeckType, List<Card>>() 
            {
                { DeckType.ATTACKDECK, FightPlayers[BattleStatus.ATTACK].Deck.OnBattleground },
                { DeckType.PROTECTION, FightPlayers[BattleStatus.PROTECTION].Deck.OnBattleground },
            };

            DataAttack.Values.ToList().RemoveAll(item => item == null);

            if (DataAttack[DeckType.ATTACKDECK].Count != 0)
                FightAlgoritm(DataAttack);

            resetPlayersData(Players);

            return FightPlayers[BattleStatus.PROTECTION].HealthNexus <= 0 ? null : Players;
        }

        /// <summary>
        /// Используется после битвы, чтобы обновить данные игроков
        /// </summary>
        /// <param name="Players">Список игроков</param>
        private static void resetPlayersData(List<Player> Players)
        {
            Game.CurrentRound++;
            Game.resetPlayersMana(Players);
            Game.addCardToPlayer(Players);

            foreach (var Player in Players)
            {
                foreach (var card in Player.Deck.OnBattleground)
                    Player.Deck.OnField.Add(card);
                Player.Deck.OnBattleground.Clear();
                Player.Move = false;
            }
        }

        /// <summary>
        /// Алгоритм битвы => Карты игроков наносят по удару друг другу
        /// Если у какой-либо из карт здоровье ниже 0, она удаляется
        /// </summary>
        /// <param name="DataAttack">Список колод на поле битвы</param>
        private static void FightAlgoritm(Dictionary<DeckType, List<Card>> DataAttack)
        {
            for(int i = 0; i < DataAttack[DeckType.ATTACKDECK].Count; i++)
            {
                if (i > DataAttack[DeckType.PROTECTION].Count-1)
                    FightPlayers[BattleStatus.PROTECTION].HealthNexus -= ((Hero)DataAttack[DeckType.ATTACKDECK][i]).Damage;

                else
                {
                    ((Hero)DataAttack[DeckType.ATTACKDECK][i]).Health -= ((Hero)DataAttack[DeckType.PROTECTION][i]).Damage;
                    ((Hero)DataAttack[DeckType.PROTECTION][i]).Health -= ((Hero)DataAttack[DeckType.ATTACKDECK][i]).Damage;
                }
            }

            foreach(var Cards in DataAttack)
                foreach(var card in new List<Card>(Cards.Value))
                    if (((Hero)card).Health <= 0)
                        DataAttack[Cards.Key].Remove(card);
        }
        /// <summary>
        /// Пробегает по картам и если находит карту заклинания, то применяет её
        /// </summary>
        /// <param name="Players">Список игроков</param>
        public static void castPotion(List<Player> Players)
        {
            foreach (var player in Players)
            {
                foreach (var card in new List<Card>(player.Deck.OnBattleground))
                    if (card is Potion)
                        applyPotion(player.Deck.OnBattleground, (Potion)card);
            }
        }
        /// <summary>
        /// Пробегает по всем картам героев и применяем к ним заклинание
        /// </summary>
        /// <param name="Cards">Колода игрока</param>
        /// <param name="potion">Карта заклинания</param>

        public static void applyPotion(List<Card> Cards, Potion potion)
        {

            foreach (var card in Cards)
            {
                if (card is Hero)
                {
                        switch (potion.TypePotion)
                        {
                            case PotionType.DAMAGE:
                                ((Hero)card).Damage += potion.Effect; break;
                            case PotionType.HEALTH:
                                ((Hero)card).Health += potion.Effect; break;
                        }
                }
            }
            Cards.Remove(potion);
        }

    }
}
