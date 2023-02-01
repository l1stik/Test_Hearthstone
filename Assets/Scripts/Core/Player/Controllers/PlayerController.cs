using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Core.Card;
using UnityEngine;
using Zenject;
using Task = System.Threading.Tasks.Task;

namespace Core.Player.Controllers
{
    public class PlayerController
    {
        [Inject]
        private CardView _cardViewPrefab;

        private List<CardView> _cardsView;

        private CancellationTokenSource _cancelTokenSource;

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

        public void EndCardsChoice()
        {
            _cancelTokenSource.Cancel();
        }

        public async Task<Task> ChooseCard(CancellationTokenSource cancelTokenSource)
        {
            var token = cancelTokenSource.Token;
            
            Task task = new Task(() =>
            {
                if (token.IsCancellationRequested)
                {
                    
                }
            }, token);
            task.Start();
            
            return Task.CompletedTask;
        }
    }
}