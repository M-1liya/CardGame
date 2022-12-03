
using CardGame.Assets.Model.Cards;
using CardGame.Assets.Models;
using System.Collections.Generic;
using System.Drawing.Text;

namespace CardGame.Assets
{
    public static class Fight
    {
        static Player? AttakPlayer;
        static Player? DefendPlayer;
        public static Dictionary<string, Player> Start(Dictionary<string, Player> Players)
        {
            foreach (var player in Players)
            {

                if (player.Value.BattleStatus == BattleStatus.ATTACK)
                    AttakPlayer = player.Value;
                else 
                    DefendPlayer= player.Value;


                foreach (var card in new List<Card>(player.Value.Deck.OnBattleground))
                    if (card is Potion)
                        Game.castPotion(player.Value.Deck.OnBattleground, (Potion)card);
            }

            if (AttakPlayer == null || DefendPlayer == null)
                throw new Exception("Battle status of players must be different!");


            List<List<Card>> DataAttack = new() 
            { 
                AttakPlayer.Deck.OnBattleground,
                DefendPlayer.Deck.OnBattleground
            };



            if (DataAttack[0].Count == 0) return Players;

            FightAlgoritm(DataAttack);

            if (DefendPlayer.HealthNexus <= 0)
                return null;


            return Players;
        }

        //Теперь за один бой герои наносят по одному удару
        //Наносит урон нексусу только атакующий
        //при условии что его никто не блокирует 
        private static void FightAlgoritm(List<List<Card>> DataAttack)
        {
            for(int i = 0; i < DataAttack[0].Count; i++)
            {
                if (i > DataAttack[1].Count)
                    DefendPlayer.HealthNexus -= ((Hero)DataAttack[0][i]).Damage;

                else
                {
                    List<Card> DuelRes =  Duel(DataAttack[0][i], DataAttack[1][i]);
                    DataAttack[0][i] = DuelRes[0]; 
                    DataAttack[1][i] = DuelRes[1]; 
                }
            }

            DeleteDeadHero(DataAttack[0]);
            DeleteDeadHero(DataAttack[1]);

            void DeleteDeadHero(List<Card> Cards) 
            {
                List<Card> tmp = Cards;
                foreach (var card in tmp)
                {
                    if (((Hero)card).Health <= 0)
                    {
                        Cards.Remove(card);
                    }
                }
            }
        }

        private static List<Card> Duel(Card heroA, Card heroD)
        {
            
            Hero AttackHero = (Hero)heroA;
            Hero DefendHero = (Hero)heroD;

            DefendHero.Health -= AttackHero.Damage;
            AttackHero.Health -= DefendHero.Damage;

            List <Card> res = new() 
            {
                AttackHero,
                DefendHero
            };

            return res;
        }
    }
}
