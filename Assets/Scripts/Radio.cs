using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Radio : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject radioSound;


    void Start()
    {
        radioSound.SetActive(false);
    }

    
    public void Activated()
    {
        if (radioSound.activeInHierarchy)
        {
            radioSound.SetActive(false);
        }
        else
        {
            radioSound.SetActive(true);
        }
    }

    public Vector3 GetInteractablePosition()
    {
        return transform.position;
    }
}
