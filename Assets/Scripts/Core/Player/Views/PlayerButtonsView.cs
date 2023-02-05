using Core.Card;
using Core.Player.Processes;
using UnityEngine;
using UnityEngine.UI;

namespace Core.Player.Views
{
    public class PlayerButtonsView : MonoBehaviour
    {
        [SerializeField] 
        private Button _stopPlayerCardChoosing;
        
        [SerializeField]
        private Button _randomizeCardStats;
        
        private PlayerChooseCardProcess _chooseCardProcess;

        public void Initialize(PlayerChooseCardProcess chooseCardProcess)
        {
            _chooseCardProcess = chooseCardProcess;
        }

        private void Start()
        {
            _stopPlayerCardChoosing.onClick.AddListener(_chooseCardProcess.CompleteChooseCardProcess);
        }
        
        private void OnDestroy()
        {
            _stopPlayerCardChoosing.onClick.RemoveListener(_chooseCardProcess.CompleteChooseCardProcess);
        }

        public void DisplayCards()
        {
            
        }

        public void AddCard(CardView cardView)
        {
            _chooseCardProcess.AddCard(cardView);
        }
        
        public void RemoveCard(CardView cardView)
        {
            _chooseCardProcess.RemoveCard(cardView);
        }
    }
}