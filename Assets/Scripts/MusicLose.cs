using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MusicLose : MonoBehaviour
{
    public UnityEvent OnCollisionEvent;

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("Player") )
        {
            OnCollisionEvent.Invoke();
        }
    }
}
