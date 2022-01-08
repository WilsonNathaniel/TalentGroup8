using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    public TriggerSwitch switchbool;
    private Animator anim;

    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(switchbool.isSwitched == true)
        {
            anim.SetBool("IsOff", true);
        }
    }
}
