using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    public GameObject explosion;

    private void OnTriggerEnter(Collider other)
    {
        // if (other.CompareTag("cube"))
        if (other.CompareTag("Asteroid"))
        {
            // Handle collision logic here
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(other.gameObject); // Destroy the asteroid
            Destroy(gameObject); // Destroy the bullet
            
        }
    }
}

