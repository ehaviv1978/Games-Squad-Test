using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class Chest : MonoBehaviour, IInteractable
{
    [SerializeField] private AudioClip chestOpenSound;
    [SerializeField] [Range(0, 1)] private float chestOpenVolume = 0.5f;
    [SerializeField] private AudioClip chestLockSound;
    [SerializeField] [Range(0, 1)] private float chestLockVolume = 0.5f;

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
            animator.SetTrigger("Open Chest");
            AudioSource.PlayClipAtPoint(chestOpenSound, Camera.main.transform.position, chestOpenVolume);
            isOpen = true;
        }
        else
        {
            animator.SetTrigger("Close Chest");
            AudioSource.PlayClipAtPoint(chestOpenSound, Camera.main.transform.position, chestOpenVolume);
            isOpen = false;
        }
    }

    public void PlayChestLockSound()
    {
        AudioSource.PlayClipAtPoint(chestLockSound, Camera.main.transform.position, chestLockVolume);
    }
}
