using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorAutomatic : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("character_nearby", true);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("character_nearby", false);
    }
}
