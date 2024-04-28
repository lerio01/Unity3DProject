using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class CoinPick : MonoBehaviour
{
   private float coins = 0;

   public TMP_Text coinsText;

   private void OnTriggerEnter(Collider coll) 
    {
        if(coll.gameObject.tag=="Coin")
        {
          coins++;
          coinsText.text = coins.ToString();
          Destroy(coll.gameObject);
        }
    }
}
