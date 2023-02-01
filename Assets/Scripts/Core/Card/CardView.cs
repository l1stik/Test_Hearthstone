using System;
using Core.Other;
using UnityEngine;

namespace Core.Card
{
    [RequireComponent(typeof(DragAndDropComponent))]
    public class CardView : MonoBehaviour
    {

        private const string fieldTag = "Field";
        private event Action OnTriggerEnterEvent = delegate { };
        private event Action OnTriggerExitEvent = delegate { };
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.CompareTag(fieldTag))
            {
                OnTriggerEnterEvent?.Invoke();
            }
        }
        
        private void OnTriggerExit(Collider other)
        {
            if (other.transform.CompareTag(fieldTag))
            {
                OnTriggerExitEvent?.Invoke();
            }
        }
    }
}