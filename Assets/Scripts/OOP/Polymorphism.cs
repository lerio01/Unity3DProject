using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Polymorphism script

public class Polymorphism : MonoBehaviour
{
    public class Ground{}
    public class Bush : Ground
    {
        public void Swish()
        {
            Debug.Log ("The bush rustles");
        }
    }
    public class Tree : Ground
    {
        public void Height()
        {
            Debug.Log ("The tree grows");
        }
    }

    public class Game
    {
        public Ground[] gr;
        public Game ()
        {
            gr = new Ground[2];
            gr[0] = new Bush();
            gr[1] = new Tree(); 
            if(gr[0] is Bush)
            {
                Bush b = gr[0] as Bush;
                b.Swish();
            }
            Tree t = (Tree)gr[1];
            t.Height();
        }
    }
}
