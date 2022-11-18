using CardGame.Assets.nsDeck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Assets
{
    public class Player
    {
        private List<Card> _handCard = new List<Card>();
        public int elexir;
        public List<Card> getHandCard => _handCard;
        public void addHandCard(Card card) { _handCard.Add(card); }
        public void removeHandCard(Card card) { _handCard.Remove(card); }
    }
}
