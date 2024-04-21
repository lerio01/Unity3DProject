using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Namespace script

namespace Ball
{
    public class BallTransform : UnityEngine.MonoBehaviour
    {
        public Vector3 scaleChange;
        public Vector3 speed;
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

            rb = GetComponent<Rigidbody>();
            // transform.localScale += scaleChange;
            transform.position += speed;
            if (transform.position.x <= stoppingPosition.x)
            {
                transform.position = stoppingPosition;
                rb.angularVelocity = Vector3.zero;

            }
        }
    }
}
