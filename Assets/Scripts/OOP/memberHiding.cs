using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Member Hiding script

public class Penguin
{
    public void P()
    {
        Debug.Log ("Penguin don't fly");
    }
}
public class Eagle: Penguin
{
    public void P()
    {
        Debug.Log ("Eagle flies");
    }
}
public class Parrot: Eagle
{
    public void P()
    {
        Debug.Log ("Parrot flies");
    }
}

public class Birds : MonoBehaviour
{
    void Start () 
    {
        Penguin penguin = new Penguin();
        Penguin eagle = new Eagle();
        Penguin parrot = new Parrot();
        
        penguin.P();
        eagle.P();
        parrot.P();
    }
}