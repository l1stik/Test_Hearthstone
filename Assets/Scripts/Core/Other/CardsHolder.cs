using UnityEngine;

namespace Core.Other
{
    public class CardsHolder : MonoBehaviour
    {
        [SerializeField] 
        private Transform _holderForPlayer;
        
        [SerializeField] 
        private Transform _holderForAiPlayer;
        
        public Transform HolderForAiPlayer => _holderForAiPlayer;
        public Transform HolderForPlayer => _holderForPlayer;
    }
}