using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVictory : MonoBehaviour
{
    
    private AudioSource audioSource;

    void Start()
    {       
        audioSource = GetComponent<AudioSource>();       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {  
            audioSource.Play(); 
        }
    }
}
