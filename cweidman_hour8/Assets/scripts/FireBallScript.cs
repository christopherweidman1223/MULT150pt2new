using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    int TakeDamageFromFireball()
    {
        return 100;
    }

    int TakeDamageFromFireball(int damage)
    {
        return 100 - damage;
    }

    int TakeDamageFromFireball(int damage, int health)
    {
        return health - damage;
    }

    void Start()
    {
        int x = TakeDamageFromFireball();
        print("Player health: " + x);

        int y = TakeDamageFromFireball(25);
        print("Player health: " + y);

        int z = TakeDamageFromFireball(30, 50);
        print("Player health: " + z);
    }
}