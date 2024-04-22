using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Namespace script

namespace Ball
{
    public class BallTransform : UnityEngine.MonoBehaviour
    {
        public Vector3 scaleChange;
        public float speed = 0.1f; 
        public Vector3 stoppingPosition = new Vector3(-55f, 6.22f, 39f);
        Rigidbody rb;
       
        void Start()
        {
           
            ball b = new ball();           
            b.Experience = 5;
            int x = b.Experience;           
        }

        void Update()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            rb = GetComponent<Rigidbody>();
            
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);
            
            if (transform.position.x <= stoppingPosition.x)
            {
                //transform.position = stoppingPosition;
                rb.angularVelocity = Vector3.zero;
            }
        }
        
    }
}
