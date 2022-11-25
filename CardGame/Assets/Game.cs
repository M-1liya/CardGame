using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Assets.nsDeck;

namespace CardGame.Assets
{
    public static class Game
    {
        private static int _currentRound = 1;
        public static void Start(Dictionary<string, Player> Players)
        {
            distributionPlayersCards(Players.Values.ToList());
            resetPlayersMana(Players.Values.ToList());
        }
        public static void distributionPlayersCards(List<Player> Players)
        {
            foreach (var player in Players)
            {
                Deck deck = new Deck();
                for (int i = 0; i < 5; i++)
                    player.HandCard.Add(deck.getCards());
            }
        }
        public static void resetPlayersMana(List<Player> Players)
        {
            foreach (var player in Players)
                    player.Mana = _currentRound;
        }

        /*public static Dictionary<Player, List<Card>> gameFight(Dictionary<Player, List<Card>> DataAttack)
        {
            foreach(var item in DataAttack)
                foreach (var card in new List<Card>(item.Value))
                    if(card is Potion)
                        castPotion(item.Value, (Potion)card);

            fight(DataAttack.Values.ToList());
            
            foreach (var item in DataAttack)
                if (item.Value.Count == 0)
                    item.Key.HealthNexus = attackNexus(item.Key.HealthNexus, DataAttack.Values.ToList());

            CurrentRound += 1;
            resetPlayersMana(DataAttack.Keys.ToList());
            return DataAttack;
        }
*/
        public static Dictionary<string, Player> fight(Dictionary<string, Player> Players)
        {
            foreach (var player in Players)
                foreach (var card in new List<Card>(player.Value.CardsOnBattleground))
                    if (card is Potion)
                        castPotion(player.Value.CardsOnBattleground, (Potion)card);
            List<List<Card>> DataAttack = new List<List<Card>>();
            foreach (var player in Players)
                DataAttack.Add(player.Value.CardsOnBattleground);

            fightAlgoritm(DataAttack);

            foreach (var player in Players)
            {
                if (player.Value.CardsOnBattleground.Count == 0)
                    player.Value.HealthNexus = attackNexus(player.Value.HealthNexus, DataAttack);
                if (player.Value.HealthNexus <= 0)
                    return null;
            }

            CurrentRound += 1;
            resetPlayersMana(Players.Values.ToList());
            return Players;
        }
        public static int attackNexus(int nexus, List<List<Card>> DataAttack)
        {
            foreach (var item in DataAttack)
                if (item.Count != 0)
                    foreach(var card in item)
                        nexus -= ((Hero)card).Damage;
            return nexus;
        }
        public static void fightAlgoritm(List< List<Card> > DataAttack)
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
                            case Potion.ETypePotion.Damage:
                                ((Hero)card).Damage += potion.Effect; break;
                            case Potion.ETypePotion.Health:
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
                player.Value.BattleStatus = (player.Value.BattleStatus == Player.EBattleStatus.Attack) ?
                    Player.EBattleStatus.Protection : Player.EBattleStatus.Attack;
        }
    }
}

