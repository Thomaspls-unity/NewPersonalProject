using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerInteraction : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GetComponentInParent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            if (player.HasCoin())
            {
                return;
            }
        }

        player.MakeItemAvailable(other.transform);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Pickup"))
        {
            player.MakeItemUnavailable();
        }
    }
}
