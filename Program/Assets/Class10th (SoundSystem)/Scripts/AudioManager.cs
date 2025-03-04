using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    private void Awake()
    {
        
    }

    public void Listener(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }


    void Update()
    {
        
    }
}
