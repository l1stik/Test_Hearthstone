using Core.Card.Factory;
using Core.MetaData;
using Zenject;

namespace Core.Battle
{
    public class GameRunner
    {
        [Inject]
        private RoundPlayer _roundPlayer;
        
        [Inject]
        private void Initialize(CardConfigBuildingFactory cardConfigBuildingFactory)
        {
            cardConfigBuildingFactory.LoadAndBind(GameConstants.PathToCardsConfig);
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