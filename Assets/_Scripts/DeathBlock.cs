using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBlock : MonoBehaviour
{
    public PlayerMovement player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.Respawn_Player();
        }
    }
}
