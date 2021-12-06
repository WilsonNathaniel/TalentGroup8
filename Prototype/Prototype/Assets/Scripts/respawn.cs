using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnpoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = respawnpoint.transform.position;
    }
}
