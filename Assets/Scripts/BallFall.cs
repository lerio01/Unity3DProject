using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFall : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        
        MusicLose m = GetComponent<MusicLose>();

        audioSource = GetComponent<AudioSource>();
        m.OnCollisionEvent.AddListener(PlayMusic);
    }

    
    private void PlayMusic()
    {
        audioSource.Play(); 
    }
}
