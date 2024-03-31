using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power_up : MonoBehaviour
{
    public float multiplier = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "player_col")
        {
           // Ballroll.speed *= multiplier;
            Destroy(gameObject); //Kill
        }
    }
}
