using Core.Card.Factory;
using Zenject;

namespace Core.Battle
{
    public class GameRunner
    {
        [Inject]
        private RoundPlayer _roundPlayer;
        
        [Inject]
        private GameRunner(CardConfigBuildingFactory cardConfigBuildingFactory)
        {
            cardConfigBuildingFactory.LoadAndBind();
        }
        
        public void PreparingForBattle()
        {
            _roundPlayer.Preparing();
        }
        
        public void StartBattle()
        {
            _roundPlayer.StartBattle();
        }

        public void EndGame()
        {
            _roundPlayer.CalculateRoundResults();
        }
        
        public void ChangeRound()
        {
            
        }
    }
}