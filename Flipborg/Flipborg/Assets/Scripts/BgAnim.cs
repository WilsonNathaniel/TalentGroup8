using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgAnim : MonoBehaviour
{

    public TriggerSwitch trigger;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        if(trigger.isSwitched == true)
        {
            anim.SetBool("IsTrig", true);
        }


    }
}
