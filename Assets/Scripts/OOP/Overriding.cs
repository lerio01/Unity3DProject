using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Overriding script

public class Product 
{
    public Product ()
    {
        Debug.Log("1st Product Constructor Called");
    }
    public virtual void Prepare ()
    {
        Debug.Log("The product has been prepared.");        
    }
    public virtual void Introduce ()
    {
        Debug.Log("Hello, I am a product.");
    }
}

public class BananaProduct : Product 
{
    public BananaProduct ()
    {
        Debug.Log("1st BananaProduct Constructor Called");
    }
    public override void Prepare ()
    {
        base.Prepare();
        Debug.Log("The banana has been prepared.");        
    }

    public override void Introduce ()
    {
        base.Introduce();
        Debug.Log("Hello, I am a BananaProduct.");
    }
}

public class SaladMaker : MonoBehaviour 
{    
    void Start () 
    {
        BananaProduct banana = new BananaProduct();
        
        banana.Introduce();
        banana.Prepare();    
        
        Product myProduct = new BananaProduct();
        myProduct.Introduce();
        myProduct.Prepare();
    }
}
