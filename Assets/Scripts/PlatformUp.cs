using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour
{
    public float moveSpeed = 2f; 
    public float moveDistance = 2f; 
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    
    void Update()
    {
        Vector3 newPos = startPos + new Vector3(0, Mathf.PingPong(Time.time * moveSpeed, moveDistance), 0);
        transform.position = newPos;
    }
}
