using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Canvas canvasInteractables;

    private IInteractable currentInteractable;
    private GameObject interactableInRangeGameObject;


    void Start()
    {
        canvasInteractables.enabled = false;
    }


    void Update()
    {
        if (interactableInRangeGameObject)
        {
            InteractableInView();
        }

        if (Input.GetKeyDown(KeyCode.F) && currentInteractable != null)
        {
            currentInteractable.Activated();
        }
    }

    
    private void InteractableInView()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(interactableInRangeGameObject.GetComponent<BoxCollider>().transform.position);
        if (viewPos.x >= -0.5 && viewPos.x <= 1.5 && viewPos.y >= -0.5 && viewPos.y <= 1.5 && viewPos.z > 0)
        {
            canvasInteractables.enabled = true;
            currentInteractable = interactableInRangeGameObject.gameObject.GetComponent<IInteractable>();
        }
        else
        {
            canvasInteractables.enabled = false;
            currentInteractable = null;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IInteractable>() != null)
        {
            interactableInRangeGameObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<IInteractable>() != null)
        {
            interactableInRangeGameObject = null;
            canvasInteractables.enabled = false;
            currentInteractable = null;
        }
    }
}
