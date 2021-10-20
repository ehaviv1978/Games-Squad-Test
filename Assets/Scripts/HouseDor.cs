using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class HouseDor : MonoBehaviour, IInteractable
{
    [SerializeField] private AudioClip dorOpenSound;
    [SerializeField] [Range(0, 1)] private float dorOpenVolume = 0.5f;
    [SerializeField] private AudioClip dorLockSound;
    [SerializeField] [Range(0, 1)] private float dorLockVolume = 0.5f;

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
            AudioSource.PlayClipAtPoint(dorOpenSound, Camera.main.transform.position, dorOpenVolume);
            isOpen = true;
        }
        else
        {
            animator.SetTrigger("Close Dor");
            AudioSource.PlayClipAtPoint(dorOpenSound, Camera.main.transform.position, dorOpenVolume);
            isOpen = false;
        }
    }

    public void PlayLockSound()
    {
        AudioSource.PlayClipAtPoint(dorLockSound, Camera.main.transform.position, dorLockVolume);
    }
}
