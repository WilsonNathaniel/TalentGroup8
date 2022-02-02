using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUi : MonoBehaviour
{

    public cameramove cm;
    public cameramove cm2;
    public GameObject FlipTutor;
    public GameObject MoveTutor;
    public GameObject InteractTutor;
    void Update()
    {
        if(cm.activated == true)
        {
            MoveTutor.SetActive(false);
            InteractTutor.SetActive(false);
            FlipTutor.SetActive(true);
        }

        if (cm2.activated == true)
        {
            FlipTutor.SetActive(false);
        }
    }
}
