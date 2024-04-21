using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Statics script

public class Fire
{
    public static int fireCount = 0;

    public Fire()
    {
        fireCount++;
    }
}

public class Game : MonoBehaviour
{
    void Start()
    {
        Fire f1 = new Fire();
        Fire f2 = new Fire();
        Fire f3 = new Fire();

        int u = Fire.fireCount;
    }
}