using System.Threading;
using System.Threading.Tasks;
using Core.Card;
using Core.Player.Controllers;

namespace Core.Player.Processes
{
    public class PlayerChooseCardProcess
    {
        private CancellationTokenSource _cancelTokenSource;
        
        private PlayerController _playerController;

        public void Initialize(PlayerController playerController)
        {
            _playerController = playerController;
        }
        
        public void AddCard(CardView cardView)
        {
            _playerController.AddCardToField(cardView);
        }
        
        public void RemoveCard(CardView cardView)
        {
            _playerController.RemoveCardFromField(cardView);
        }
        
        public void CompleteChooseCardProcess()
        {
            _cancelTokenSource.Cancel();
        }

        public async Task<Task> RunChooseCardProcess(CancellationTokenSource cancelTokenSource)
        {
            var token = cancelTokenSource.Token;
            
            Task task = new Task(() =>
            {
                if (token.IsCancellationRequested)
                {
                    // выбирает карты, ожидаем завершение по кнопке
                }
                
            }, token);
            task.Start();

            await task;
            
            return Task.CompletedTask;
        }
    }
}