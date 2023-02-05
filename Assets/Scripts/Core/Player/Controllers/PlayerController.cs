using System.Collections.Generic;
using Core.Card;
using Core.Field;
using UnityEngine;
using Zenject;

namespace Core.Player.Controllers
{
    public class PlayerController
    {
        [Inject]
        private CardBuilder _cardBuilder;

        private List<CardView> _cardsView;

        private FieldController _fieldController;

        public void Initialize(FieldController fieldController)
        {
            _fieldController = fieldController;
        }

        public void GenerateCardPool(int count, Transform parent)
        {
            _cardsView = _cardBuilder.BuildCard(count, parent);
        }

        public void AddCardToField(CardView cardView)
        {
            _fieldController.AddCardToField(cardView);
        }
        
        public void RemoveCardFromField(CardView cardView)
        {
            _fieldController.RemoveCardFromField(cardView);
        }
    }
}