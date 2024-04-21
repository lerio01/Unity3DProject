using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Extension Methods

    public static class ExtensionMethods
    {
        public static void ResetTransformation(this Transform trans)
        {
            trans.position = Vector3.zero;
            trans.localRotation = Quaternion.identity;
            trans.localScale = new Vector3(1, 1, 1);
        }
    }

public class JustClass : MonoBehaviour 
{
    void Start () 
    {
        transform.ResetTransformation();
    }
}
