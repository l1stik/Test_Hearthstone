using Core.Card;
using Core.Player.Controllers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Core.Player.Views
{
    public class PlayerView : MonoBehaviour
    {

        [SerializeField]
        private Button _chooseCardButton;
        
        [Inject]
        private PlayerController _playerController;

        private void Start()
        {
            _chooseCardButton.onClick.AddListener(_playerController.EndCardsChoice);
        }
        
        private void OnDestroy()
        {
            _chooseCardButton.onClick.RemoveListener(_playerController.EndCardsChoice);
        }

        public void Init()
        {
            
        }
        
        public void DisplayAnimation(CardView cardView)
        {
            
        }
        
        public void ChangeCardData(CardView cardView)
        {
            
        }
    }
}