using System.Collections.Generic;

namespace CardGame.Assets.Model.Cards
{
    public class Deck
    {
        private List<Card> _onHand;
        private List<Card> _onField;
        private List<Card> _onBattleground;

        public Deck()
        {
            OnHand = new List<Card>();
            OnField = new List<Card>();
            OnBattleground = new List<Card>();
        }

        public List<Card> OnHand
        {
            get => _onHand;
            set => _onHand = value;
        }
        public List<Card> OnField
        {
            get => _onField;
            set => _onField = value;
        }
        public List<Card> OnBattleground
        {
            get => _onBattleground;
            set => _onBattleground = value;
        }
    }
}
