using Core.Field;
using Core.Player;
using Zenject;

namespace Core.Battle
{
    public class RoundPlayer
    {
        [Inject(Id = 0)]
        private FieldController _aiFieldController;
        
        [Inject(Id = 1)]
        private FieldController _playerFieldController;
        
        [Inject] 
        private BrainPlayers _brainPlayers;
        
        public async void Preparing()
        {
            await _brainPlayers.Preparation();
            StartBattle();
        }
        
        public void StartBattle()
        {
        }
        
        public void EndBattle()
        {
        }
        
        public void CalculateRoundResults()
        {
            _aiFieldController.CalculateDamage();
            _playerFieldController.CalculateDamage();
        }
    }
}