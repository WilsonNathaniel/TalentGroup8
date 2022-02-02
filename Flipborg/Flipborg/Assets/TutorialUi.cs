using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUi : MonoBehaviour
{

    public cameramove cm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cm.activated == true)
        {
            gameObject.SetActive(false);
        }
    }
}
