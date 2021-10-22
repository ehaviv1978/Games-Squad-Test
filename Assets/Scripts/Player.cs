using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Canvas canvasInteractables;

    private IInteractable currentInteractable;
    private bool isInteractableInView = false;
    //private GameObject interactableInRangeGameObject;


    void Start()
    {
        canvasInteractables.enabled = false;
    }


    void Update()
    {
        if (currentInteractable != null)
        {
            InteractableInView();
        }

        if (Input.GetKeyDown(KeyCode.F) && isInteractableInView)
        {
            if (currentInteractable != null)
                currentInteractable.Activated();
        }
    }

    
    private void InteractableInView()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(currentInteractable.GetInteractablePosition());
        if (viewPos.x >= 0 && viewPos.x <= 1 && viewPos.y >= 0 && viewPos.y <= 1 && viewPos.z > 0)
        {
            canvasInteractables.enabled = true;
            isInteractableInView = true;
            //currentInteractable = interactableInRangeGameObject.gameObject.GetComponent<IInteractable>();
        }
        else
        {
            canvasInteractables.enabled = false;
            isInteractableInView = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponentInParent<IInteractable>() != null)
        {
            currentInteractable = other.gameObject.GetComponentInParent<IInteractable>();
            //interactableInRangeGameObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponentInParent<IInteractable>() != null)
        {
            //interactableInRangeGameObject = null;
            canvasInteractables.enabled = false;
            currentInteractable = null;
        }
    }
}
