using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the "Bullet" tag
        if (other.CompareTag("Bullet"))
        {
            // Check if the object that entered the trigger has a Rigidbody (bullet should have one)
            Rigidbody bulletRigidbody = other.GetComponent<Rigidbody>();
            if (bulletRigidbody != null)
            {

                // Destroy the asteroid
                Destroy(gameObject);

                // Destroy the bullet
                Destroy(other.gameObject);
            }
        }
    }
}
