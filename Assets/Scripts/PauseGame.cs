using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
  public void SetPause(bool isEnabled)
   {
      Time.timeScale = isEnabled ? 0 : 1;
   }

}
