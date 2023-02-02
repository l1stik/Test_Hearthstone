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
        private CardView _cardViewPrefab;

        private List<CardView> _cardsView;

        private FieldController _fieldController;

        public void Initialize(FieldController fieldController)
        {
            _fieldController = fieldController;
        }

        public void GenerateCardPool(int count, Transform parent)
        {
            _cardsView = new List<CardView>(count);
            for (var i = 0; i < count; i++)
            {
                var card = UnityEngine.Object.Instantiate(_cardViewPrefab, parent, false);
                // метод с настройкой карты
                _cardsView.Add(card);
            }
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