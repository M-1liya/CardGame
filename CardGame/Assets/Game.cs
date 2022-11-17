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
        public void RerenderList(ComboBox comboBox, Player P)
        {
            comboBox.Items.Clear();

            foreach (Card card in P.handCard)   //Определяем тип карты, и выводим её св-ва на экран
            {
                if(card.GetTypeCard == Card.TypeCard.Hero)
                {
                    Hero hero = (Hero)card;
                    comboBox.Items.Add(hero.ToString());
                }
                if(card.GetTypeCard == Card.TypeCard.Potion)
                {
                    Potion potion = (Potion)card;
                    comboBox.Items.Add(potion.ToString());
                }

            }
            
        }
    }
}
