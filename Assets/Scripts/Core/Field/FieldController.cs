using System.Collections.Generic;
using System.Linq;
using Core.Card;

namespace Core.Field
{
    public class FieldController 
    {
        private List<CardView> _cardsOnField;
        
        public List<CardView> GetCardsOnField()
        {
            return _cardsOnField;
        }
        
        public CardView GetCardOnField(int cardId)
        {
            return _cardsOnField.First(card => card.Id == cardId);
        }
        
        public void AddCardToField(CardView cardView)
        {
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
    }
}