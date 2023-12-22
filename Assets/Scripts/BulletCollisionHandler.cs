
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    public GameObject explosion;
    public ScoreManager scoreManager;
    public int asteroidScore = 10;
    public AudioClip explosionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            // Handle collision logic here
            Instantiate(explosion, transform.position, transform.rotation);

            // Get the ScoreManager from the scene
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

            if (explosionSound != null)
            {
                // Create an AudioSource
                AudioSource audioSource = gameObject.AddComponent<AudioSource>();
                audioSource.clip = explosionSound;

                // Play the sound
                audioSource.Play();

                // Destroy the AudioSource after the sound has played
                Destroy(audioSource, explosionSound.length);
            }

            if (scoreManager != null)
            {
                // Update the score and UI
                scoreManager.AddScore(asteroidScore);
            }

            Destroy(other.gameObject); // Destroy the asteroid
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
