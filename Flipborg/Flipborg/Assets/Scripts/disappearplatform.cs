using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearplatform : MonoBehaviour
{
    [SerializeField] private float appeardelay = 1f;
    [SerializeField] private float disappeardelay = 1f;
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerFeet")
        {
            Invoke("enablegameobject", appeardelay);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerFeet")
        {
            Invoke("disablegameobject", disappeardelay);
        }
    }

    void disablegameobject()
    {
        gameObject.SetActive(false);
    }

    void enablegameobject()
    {
        gameObject.SetActive(true);
    }
}
