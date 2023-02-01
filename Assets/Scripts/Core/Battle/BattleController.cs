using Core.Player;
using Zenject;

namespace Core.Battle
{
    public class BattleController
    {
        [Inject] 
        private BrainPlayersController _brainPlayersController;
        
        public void PreparingForBattle()
        {
            _brainPlayersController.Preparation();
        }
        
        public void StartBattle()
        {
            _brainPlayersController.RunBattle();
        }
        
        public void EndBattle()
        {
            _brainPlayersController.FinishBattle();
        }
    }
}