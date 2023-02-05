using Core.SO;
using UnityEngine;
using Zenject;

namespace Core.Card.Factory
{
    public class CardConfigBuildingFactory
    {
        private const string PathToCardsConfig = "";
        
        [Inject] 
        private DiContainer _diContainer;
        
        public void LoadAndBind()
        {
            var config = Resources.Load<CardScriptableObject>(PathToCardsConfig);
            _diContainer.Bind<CardScriptableObject>().FromInstance(config).AsSingle();
        }
    }
}