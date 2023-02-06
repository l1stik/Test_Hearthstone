using Core.SO;
using UnityEngine;
using Zenject;

namespace Core.Card.Factory
{
    public class CardConfigBuildingFactory
    {
        [Inject] 
        private DiContainer _diContainer;
        
        public void LoadAndBind(string pathConfig)
        {
            var config = Resources.Load<CardScriptableObject>(pathConfig);
            _diContainer.Bind<CardScriptableObject>().FromInstance(config).AsSingle();
        }
    }
}