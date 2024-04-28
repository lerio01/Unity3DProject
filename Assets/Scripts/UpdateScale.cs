using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScale : MonoBehaviour
{
    [Range(0f, 10f)]
    public float minScale;
    [Range(0f, 10f)]
     public float maxScale;
    [Range(0f, 10f)]
     public float scaleSpeed;
     private bool isScalingUp = true;
    void Start()
    {
        
    }

    
    void Update() 
    {
        float scaleFactor = isScalingUp ? 1.0f : -1.0f;
        transform.localScale += Vector3.one * scaleFactor * scaleSpeed * Time.deltaTime;
        
        isScalingUp = transform.localScale.x < minScale ? true : (transform.localScale.x > maxScale ? false : isScalingUp);//Змінила на тернарний оператор

    }
}
