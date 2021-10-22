using UnityEngine;


namespace Assets.Scripts
{
    interface IInteractable
    {
        public void Activated();
        public Vector3 GetInteractablePosition();
    }
}
