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

    private void OnTriggerEnter(Collider other)
    {
        //animator.SetTrigger("Open Chest");
        //chestCap.transform.Rotate(new Vector3(-90, 0, 0));
    }

    private void OnTriggerExit(Collider other)
    {
        if (isOpen)
        {
            animator.SetTrigger("Close Chest");
            isOpen = false;
        }
        //chestCap.transform.Rotate(new Vector3(90, 0, 0));
    }

    public void Activated()
    {
        if (!isOpen)
        {
            animator.SetTrigger("Open Chest");
            isOpen = true;
        }
    }
}
