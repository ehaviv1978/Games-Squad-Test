using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class HouseDor : MonoBehaviour, IInteractable
{
    private Animator animator;

    private bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void Activated()
    {
        if (!isOpen)
        {
            animator.SetTrigger("Open Dor");
            isOpen = true;
        }
        else
        {
            animator.SetTrigger("Close Dor");
            isOpen = false;
        }
    }
}
