using System.Collections.Generic;
using Core.SO;
using UnityEngine;
using Zenject;

namespace Core.Card
{
    public class CardBuilder
    {
        [Inject]
        private CardView _cardViewPrefab;
        
        [Inject]
        private CardScriptableObject _cardScriptableObject;
        
        public List<CardView> BuildCard(int count, Transform parent)
        {
            var cardsView = new List<CardView>(count);
            var configs = _cardScriptableObject.GetConfigs();
            
            for (var i = 0; i < count; i++)
            {
                var card = UnityEngine.Object.Instantiate(_cardViewPrefab, parent, false);
                card.GetComponent<CardView>().SetCardConfig(configs[i]);
                
                cardsView.Add(card);
            }

            return cardsView;
        }
    }
}