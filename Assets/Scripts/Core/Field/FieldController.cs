using System.Collections.Generic;
using System.Linq;
using Core.Battle;
using Core.Card;
using Core.Card.AnimationBehaviour;
using Zenject;

namespace Core.Field
{
    public class FieldController 
    {
        private List<CardView> _cardsOnField;
        
        [Inject] 
        private CardAnimator _cardAnimator;

        [Inject] 
        private HandCalculator _handCalculator;

        public List<CardView> GetCardsOnField()
        {
            return _cardsOnField;
        }
        
        public CardView GetCardOnField(string cardName)
        {
            return _cardsOnField.First(card => card.Name == cardName);
        }
        
        public void AddCardToField(CardView cardView)
        {
            _cardAnimator.BuildCard(cardView);
            _cardsOnField.Add(cardView);
        }
        
        public void RemoveCardFromField(CardView cardView)
        {
            _cardsOnField.Remove(cardView);
        }

        public void RemoveCardsFromField()
        {
            _cardsOnField.Clear();
        }
        
        public void CalculateDamage()
        {
            _handCalculator.FillHand();
        }
    }
}