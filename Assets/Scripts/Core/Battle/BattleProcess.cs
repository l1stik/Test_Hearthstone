using Core.Field;
using Zenject;

namespace Core.Battle
{
    public class BattleProcess
    {
        [Inject(Id = 0)]
        private FieldController _aiFieldController;
        
        [Inject(Id = 1)]
        private FieldController _aiFieldPlayerController;
        
        public void StartBattle()
        {
        }
        
        public void EndBattle()
        {
        }
    }
}