using CardGame.Assets.Model;
using CardGame.Assets;
using FluentAssertions;

namespace WPFCardGameTests
{

    [TestClass]
    public class SerializationTest
    {
        [TestMethod]
        public void serializeAndDeserializeTEST()
        {
            Dictionary<string, Player> Players = new Dictionary<string, Player>()
            {
                { "P1", new Player(BattleStatus.ATTACK) },
                { "P2", new Player(BattleStatus.PROTECTION) },
            };

            Serialization.serialize(Players, new FileInfo("Players.json"));
            var deserializePlayers = Serialization.deserialize<Dictionary<string, Player>>(new FileInfo("Players.json"));
            
            //ASSERT
            foreach (var player in Players)
                player.Value.Should().BeEquivalentTo(deserializePlayers[player.Key]);

        }
    }
}
