using CardGame.Assets.Model;
using CardGame.Assets;
using CardGame.Assets.Model.Factories;
using CardGame.Assets.Model.Cards.CardType;
using CardGame.Assets.Model.Cards;

namespace WPFCardGameTests
{
    [TestClass]
    public class FightTest
    {
        [TestMethod]
        public void castPotionTest()
        {
            Dictionary<string, Player> Players = new Dictionary<string, Player>()
            {
                { "P1", new Player(BattleStatus.ATTACK) },
                { "P2", new Player(BattleStatus.PROTECTION) },
            };

            ICardFactory heroFactory = new HeroFactory();
            ICardFactory potionFactory = new PotionFactory();

            Players["P1"].Deck.OnBattleground.Add(heroFactory.Create(HeroType.DRAGON));
            Players["P1"].Deck.OnBattleground.Add(heroFactory.Create(HeroType.SHREK));
            Players["P1"].Deck.OnBattleground.Add(potionFactory.Create(PotionType.HEALTH));

            Players["P2"].Deck.OnBattleground.Add(heroFactory.Create(HeroType.DRAGON));
            Players["P2"].Deck.OnBattleground.Add(heroFactory.Create(HeroType.SHREK));
            Players["P2"].Deck.OnBattleground.Add(potionFactory.Create(PotionType.DAMAGE));
            Fight.castPotion(Players.Values.ToList());

            Dictionary<string, Player> PlayersTemp = new Dictionary<string, Player>()
            {
                { "P1", new Player(BattleStatus.ATTACK) },
                { "P2", new Player(BattleStatus.PROTECTION) },
            };

            PlayersTemp["P1"].Deck.OnBattleground.Add(heroFactory.Create(HeroType.DRAGON));
            PlayersTemp["P1"].Deck.OnBattleground.Add(heroFactory.Create(HeroType.SHREK));

            PlayersTemp["P2"].Deck.OnBattleground.Add(heroFactory.Create(HeroType.DRAGON));
            PlayersTemp["P2"].Deck.OnBattleground.Add(heroFactory.Create(HeroType.SHREK));

            for (int i = 0; i < PlayersTemp["P1"].Deck.OnBattleground.Count(); i++)
                ((Hero)PlayersTemp["P1"].Deck.OnBattleground[i]).Health += ((Potion)potionFactory.Create(PotionType.HEALTH)).Effect;
            for (int i = 0; i < PlayersTemp["P2"].Deck.OnBattleground.Count(); i++)
                ((Hero)PlayersTemp["P2"].Deck.OnBattleground[i]).Damage += ((Potion)potionFactory.Create(PotionType.DAMAGE)).Effect;

            foreach (var player in Players)
                for(int i = 0; i < player.Value.Deck.OnBattleground.Count; i++)
                {
                    Assert.AreEqual(((Hero)player.Value.Deck.OnBattleground[i]).Health, ((Hero)PlayersTemp[player.Key].Deck.OnBattleground[i]).Health);
                    Assert.AreEqual(((Hero)player.Value.Deck.OnBattleground[i]).Damage, ((Hero)PlayersTemp[player.Key].Deck.OnBattleground[i]).Damage);
                }

        }
    }
}
