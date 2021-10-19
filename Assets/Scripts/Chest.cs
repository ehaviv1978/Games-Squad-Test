using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject chestCap;

    private Animator animator;

    private bool isOpen = false;

    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Activated()
    {
        if (!isOpen)
        {
            animator.SetTrigger("Open Chest");
            isOpen = true;
        }
        else
        {
            animator.SetTrigger("Close Chest");
            isOpen = false;
        }
    }
}
