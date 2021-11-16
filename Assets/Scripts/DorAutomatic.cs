using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorAutomatic : MonoBehaviour
{
    [SerializeField] private AudioClip dorOpenSound;
    [SerializeField] [Range(0, 1)] private float dorOpenVolume = 0.5f;

    private Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("character_nearby", true);
        AudioSource.PlayClipAtPoint(dorOpenSound, Camera.main.transform.position, dorOpenVolume);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("character_nearby", false);
        AudioSource.PlayClipAtPoint(dorOpenSound, Camera.main.transform.position, dorOpenVolume);
    }
}
