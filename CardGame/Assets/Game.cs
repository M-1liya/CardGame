using CardGame.Assets.Model.Cards;
using CardGame.Assets.Model.Cards.CardType;
using CardGame.Assets.Model.Factories;
using CardGame.Assets.Models;
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
        public static void distributionPlayersCards(List<Player> Players)
        {
            foreach (var player in Players)
                for (int i = 0; i < GameConst.MAX_COUNT_HANDDECK; i++)
                    player.Deck.OnHand.Add(RandomFactory.create());
        }
        public static void resetPlayersMana(List<Player> Players)
        {
            foreach (var player in Players)
                    player.Mana = _currentRound;
        }
        public static void castPotion(List<Card> Cards, Potion potion)
        {

            foreach(var card in Cards)
            {
                if (card is Hero)
                {
                    if ( ((Hero)card).TypeHero == potion.Hero)
                    {
                        switch (potion.TypePotion)
                        {
                            case PotionType.DAMAGE:
                                ((Hero)card).Damage += potion.Effect; break;
                            case PotionType.HEALTH:
                                ((Hero)card).Health += potion.Effect; break;
                        }
                        break;
                    }
                }
            }
            Cards.Remove(potion);
        }
        public static int CurrentRound
        {
            get => _currentRound;
            set => _currentRound = value;
        }
        public static void ChangeBattleStatus(Dictionary<string, Player> Players)
        {
            foreach (var player in Players)
                player.Value.BattleStatus = (player.Value.BattleStatus == BattleStatus.ATTACK) ?
                    BattleStatus.PROTECTION : BattleStatus.ATTACK;
        }
    }
}

