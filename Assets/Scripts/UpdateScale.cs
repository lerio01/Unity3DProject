using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScale : MonoBehaviour
{
     public float minScale;
     public float maxScale;
     public float scaleSpeed;
     private bool isScalingUp = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        float scaleFactor = isScalingUp ? 1.0f : -1.0f;
        transform.localScale += Vector3.one * scaleFactor * scaleSpeed * Time.deltaTime;
        
        if (transform.localScale.x < minScale)
        {
            isScalingUp = true;
        }
        else if (transform.localScale.x > maxScale)
        {
            isScalingUp = false;
        }
    }
}
