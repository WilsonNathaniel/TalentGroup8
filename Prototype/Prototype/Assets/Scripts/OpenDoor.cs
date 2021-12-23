using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public TriggerSwitch triggerSwitch;
    public GameObject objectToDisable;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(triggerSwitch.isSwitched == true)
        {
            objectToDisable.SetActive(false);
        }
    }
}
