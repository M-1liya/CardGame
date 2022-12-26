using CardGame.Assets.Model;
using CardGame.Assets.Model.Factories;
using CardGame.Assets.Util;

namespace CardGame.Assets
{
    public static class Game
    {
        private static int _currentRound = GameConst.BASE_COUNT_ROUND;
        public static void Start(Dictionary<string, Player> Players)
        {
            distributionPlayersCards(Players.Values.ToList());
            resetPlayersMana(Players.Values.ToList());
        }
        /// <summary>
        /// Раздача карт игрокам
        /// </summary>
        /// <param name="Players">Список игроков</param>
        public static void distributionPlayersCards(List<Player> Players)
        {
            for (int i = 0; i < GameConst.MAX_COUNT_HANDDECK; i++)
                addCardToPlayer(Players);
        }
        /// <summary>
        /// Добавляем игроку карту
        /// </summary>
        /// <param name="Players">Список игроков</param>
        public static void addCardToPlayer(List<Player> Players)
        {
            foreach (var player in Players)
                    player.Deck.OnHand.Add(RandomFactory.Create());
        }
        /// <summary>
        /// Обновляем ману игроку
        /// </summary>
        /// <param name="Players">Список игроков</param>
        public static void resetPlayersMana(List<Player> Players)
        {
            foreach (var player in Players)
                    player.Mana = _currentRound;
        }
        /// <summary>
        /// Меняем BattleStatus игроков на противополжные
        /// </summary>
        /// <param name="Players">Список игроков</param>
        public static void ChangeBattleStatus(List<Player> Players)
        {
            foreach (var player in Players)
                player.BattleStatus = (player.BattleStatus == BattleStatus.ATTACK) ?
                    BattleStatus.PROTECTION : BattleStatus.ATTACK;
        }
        public static int CurrentRound
        {
            get => _currentRound;
            set => _currentRound = value;
        }
    }
}

