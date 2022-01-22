using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSwitch : MonoBehaviour
{
    public bool isSwitched = false;
    private bool isPressed = false;
  

    
 
    private void OnTriggerStay2D(Collider2D collision)
    {
     
        if (Input.GetKey(KeyCode.Q))
        {
            isPressed = true;
     //       Debug.Log("q pressed");
        }

        if (collision.gameObject.tag == "Player" && isPressed == true)
        {
            //play sound door switched off
            //ganti sprite ke dari switch nyala ke mati
            isSwitched = true;
        }
    }
}
