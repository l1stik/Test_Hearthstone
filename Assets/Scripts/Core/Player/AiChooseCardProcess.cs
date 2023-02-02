using System.Threading.Tasks;
using Core.Card;
using Core.Player.Controllers;

namespace Core.Player
{
    public class AiChooseCardProcess
    {
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
        
        public void RunChooseCardProcess()
        {
            // выбирает карты
        }
    }
}