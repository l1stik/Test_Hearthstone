using Core.Player;
using Zenject;

namespace Core.Battle
{
    public class BattleStateController
    {
        [Inject] 
        private BrainPlayersController _brainPlayersController;
        
        [Inject] 
        private BattleProcess _battleProcess;
        
        public async void PreparingForBattle()
        {
           await _brainPlayersController.Preparation();
        }
        
        public void StartBattle()
        {
            _battleProcess.StartBattle();
        }
    }
}