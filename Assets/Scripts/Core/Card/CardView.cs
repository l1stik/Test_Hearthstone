using System;
using Core.Other;
using UnityEngine;

namespace Core.Card
{
    [RequireComponent(typeof(DragAndDropComponent))]
    public class CardView : MonoBehaviour
    {
        private event Action OnTriggerEvent = delegate { };
        
        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEvent?.Invoke();
        }
    }
}