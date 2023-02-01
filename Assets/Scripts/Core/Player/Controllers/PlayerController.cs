using System.Collections.Generic;
using Core.Card;
using Core.Player.Views;
using UnityEngine;
using Zenject;

namespace Core.Player.Controllers
{
    public class PlayerController
    {
        [Inject]
        private PlayerView _playerViewPrefab;
        
        private PlayerView _playerViewInstance;
        
        [Inject]
        private CardView _cardViewPrefab;

        public PlayerController()
        {
            _playerViewInstance = UnityEngine.Object.Instantiate(_playerViewPrefab);
        }

        public void GenerateCardPool(int count, Transform parent)
        {
            var listCards = new List<CardView>(count);
            
            for (var i = 0; i < count; i++)
            {
                var card = UnityEngine.Object.Instantiate(_cardViewPrefab, parent, false);
                // метод с настройкой карты
                listCards.Add(card);
            }
            _playerViewInstance.Init(listCards);
        }
    }
}