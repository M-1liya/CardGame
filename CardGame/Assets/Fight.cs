
using CardGame.Assets.Model.Cards;

namespace CardGame.Assets
{
    public static class Fight
    {
        public static Dictionary<string, Player> start(Dictionary<string, Player> Players)
        {
            foreach (var player in Players)
                foreach (var card in new List<Card>(player.Value.Deck.OnBattleground))
                    if (card is Potion)
                        Game.castPotion(player.Value.Deck.OnBattleground, (Potion)card);
            List<List<Card>> DataAttack = new List<List<Card>>();
            foreach (var player in Players)
                DataAttack.Add(player.Value.Deck.OnBattleground);

            fightAlgoritm(DataAttack);

            foreach (var player in Players)
            {
                if (player.Value.Deck.OnBattleground.Count == 0)
                    player.Value.HealthNexus = attackNexus(player.Value.HealthNexus, DataAttack);
                if (player.Value.HealthNexus <= 0)
                    return null;
            }

            Game.CurrentRound += 1;
            Game.resetPlayersMana(Players.Values.ToList());
            return Players;
        }
        public static int attackNexus(int nexus, List<List<Card>> DataAttack)
        {
            foreach (var item in DataAttack)
                if (item.Count != 0)
                    foreach (var card in item)
                        nexus -= ((Hero)card).Damage;
            return nexus;
        }
        public static void fightAlgoritm(List<List<Card>> DataAttack)
        {
            foreach (var cards in DataAttack)
                if (cards.Count == 0)
                    return;

            List<Hero> resultDuel = duel((Hero)DataAttack[0][0], (Hero)DataAttack[1][0]);
            for (int playerCards = 0; playerCards < DataAttack.Count; playerCards++)
            {
                if (resultDuel[playerCards] != null)
                    DataAttack[playerCards][0] = resultDuel[playerCards];
                else
                    DataAttack[playerCards].Remove(DataAttack[playerCards][0]);
            }

            fightAlgoritm(DataAttack);
        }

        public static List<Hero> duel(Hero heroFirst, Hero heroSecond)
        {
            List<Hero> result = new List<Hero>();
            heroFirst.Health -= heroSecond.Damage;
            heroSecond.Health -= heroFirst.Damage;
            return new List<Hero> { heroFirst.Health > 0 ? heroFirst: null,
                                    heroSecond.Health > 0 ? heroSecond : null };
        }
    }
}
