using CardGame.Assets;

using CardGame.Assets.Model;
using CardGame.Assets.Util;


namespace WPFCardGameTests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void ChangeBattleStatusTEST()
        {
            Dictionary<string, Player> Players = new Dictionary<string, Player>()
            {
                { "P1", new Player(BattleStatus.ATTACK) },
                { "P2", new Player(BattleStatus.PROTECTION) },
            };

            //var clone = Players.ToDictionary(entry => entry.Key, entry => entry.Value);

            Dictionary<string, Player> PlayersClone = new Dictionary<string, Player>()
            {
                { "P1", new Player(BattleStatus.PROTECTION) },
                { "P2", new Player(BattleStatus.ATTACK) },
            };

            Game.ChangeBattleStatus(PlayersClone.Values.ToList());

            foreach (KeyValuePair<string, Player> entry in Players)
                Assert.AreEqual(Players[entry.Key].BattleStatus, PlayersClone[entry.Key].BattleStatus);

        }
        
        [TestMethod]
        public void resetPlayersManaTEST()
        {
            Dictionary<string, Player> Players = new Dictionary<string, Player>()
            {
                { "P1", new Player(BattleStatus.ATTACK) },
                { "P2", new Player(BattleStatus.PROTECTION) },
            };

            Game.resetPlayersMana(Players.Values.ToList());

            foreach (var player in Players)
                Assert.AreEqual(player.Value.Mana, Game.CurrentRound);
        }

        [TestMethod]
        public void distributionPlayersCardsTEST()
        {
            Dictionary<string, Player> Players = new Dictionary<string, Player>()
            {
                { "P1", new Player(BattleStatus.ATTACK) },
                { "P2", new Player(BattleStatus.PROTECTION) },
            };

            Game.distributionPlayersCards(Players.Values.ToList());

            foreach (var player in Players)
                Assert.AreEqual(player.Value.Deck.OnHand.Count, GameConst.MAX_COUNT_HANDDECK);
        }

        [TestMethod]
        public void startTEST()
        {
            resetPlayersManaTEST();
            distributionPlayersCardsTEST();
        }
    }
}