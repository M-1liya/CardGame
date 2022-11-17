using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Assets.nsDeck;

namespace CardGame.Assets
{
    public class Game
    {
        public int currentRound = 1;
        static Deck deck = new Deck();

        public void Start(Player P1, Player P2)
        {
            for(int i = 0; i < 5; i++)
            {
                P1.handCard.Add(deck.GetCard());
                P2.handCard.Add(deck.GetCard());
            }
        }
        public void RenderList(ComboBox comboBox, List<Card> cardList)
        {
            comboBox.Items.Clear();

            foreach (Card card in cardList)
            {
                if(card is Hero)
                {
                    Hero hero = (Hero)card;
                    comboBox.Items.Add($"{hero.Cost} {hero.name} А:{hero.Damage} HP:{hero.HP}");
                }
                else
                {
                    Potion potion = (Potion)card;
                    if (potion.Effect > 0)
                        comboBox.Items.Add($"{potion.Cost} {potion.name} H: {potion.Effect}");
                    else
                        comboBox.Items.Add($"{potion.Cost} {potion.name} A: {Math.Abs(potion.Effect)}");
                }
            }  
        }

        public void SetStartCard(Player P, ComboBox comboBox, List<Card> cardInHandP)
        {
            foreach (Card card in P.handCard)
            {
                cardInHandP.Add(card);
            }
            this.RenderList(comboBox, cardInHandP);
        }
    }
}
