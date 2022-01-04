using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSwitch : MonoBehaviour
{
    public bool isSwitched = false;
    private bool isPressed = false;
  //  private bool isTriggering = false;

    // Update is called once per frame
 
    private void OnTriggerStay2D(Collider2D collision)
    {
     //   Debug.Log("triggering");
        if (Input.GetKey(KeyCode.Q))
        {
            isPressed = true;
     //       Debug.Log("q pressed");
        }

        if (collision.gameObject.tag == "Player" && isPressed == true)
        {

            isSwitched = true;
        }
    }
}
