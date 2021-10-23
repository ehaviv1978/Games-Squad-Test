using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Candle : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject flame;

    
    public void Activated()
    {
        if (flame.activeInHierarchy)
        {
            flame.SetActive(false);
        }
        else
        {
            flame.SetActive(true);
        }
    }

    public Vector3 GetInteractablePosition()
    {
        return transform.position;
    }
}
