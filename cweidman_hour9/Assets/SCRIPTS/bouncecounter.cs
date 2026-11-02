using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncecounter : MonoBehaviour
{
    private int bounceCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bounceCount++;

            Debug.Log("Bounce Count: " + bounceCount);
        }
    }
}
