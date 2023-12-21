using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidDestroyer : MonoBehaviour
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        sphere.SetActive(true);

        // Check if the object that entered the trigger has the "Asteroid" tag
        // if (other.CompareTag("Asteroid"))
        if (other.CompareTag("cube"))
        {
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);

            // Check if the object that entered the trigger has a Rigidbody (asteroid should have one)
            Rigidbody asteroidRigidbody = other.GetComponent<Rigidbody>();
            if (asteroidRigidbody != null)
            {
                // You can perform additional actions specific to the asteroid here

                // Destroy the asteroid
                Destroy(other.gameObject);
            }
        }
        else if (other.CompareTag("Bullet"))
        {
            // Check if the object that entered the trigger has a Rigidbody (bullet should have one)
            Rigidbody bulletRigidbody = other.GetComponent<Rigidbody>();
            if (bulletRigidbody != null)
            {
                // You can perform additional actions specific to the bullet here

                // Destroy the bullet
                Destroy(other.gameObject);
            }
        }
    }


    /*private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that entered the trigger has the "Bullet" tag
        // if (other.CompareTag("Bullet") || other.CompareTag("Asteroid"))
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            sphere.SetActive(true);
            collision.gameObject.SetActive(false);
            Destroy(collision.gameObject);

            // Check if the object that entered the trigger has a Rigidbody (bullet should have one)
            Rigidbody bulletRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (bulletRigidbody != null)
            {

                // Destroy the asteroid
                // Destroy(gameObject);

                // Destroy the bullet
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }*/

    /*private void OnTriggerEnter(Collider other)
    {
        sphere.SetActive(true);
        // Check if the object that entered the trigger has the "Bullet" tag
        // if (other.CompareTag("Bullet") || other.CompareTag("Asteroid"))
        if (other.CompareTag("Asteroid"))
        {
            Destroy(other.gameObject);

            // Check if the object that entered the trigger has a Rigidbody (bullet should have one)
            Rigidbody bulletRigidbody = other.GetComponent<Rigidbody>();
            if (bulletRigidbody != null)
            {

                // Destroy the asteroid
                // Destroy(gameObject);

                // Destroy the bullet
                Destroy(other.gameObject);
            }
        }
    }*/
}
