using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class BigScreen : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject screenOn;


    void Start()
    {
        screenOn.SetActive(false);
    }

    
    public void Activated()
    {
        if (screenOn.activeInHierarchy)
        {
            screenOn.SetActive(false);
        }
        else
        {
            screenOn.SetActive(true);
        }
    }

    public Vector3 GetInteractablePosition()
    {
        return transform.position;
    }
}
