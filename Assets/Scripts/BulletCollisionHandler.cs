using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisionHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // if (other.CompareTag("cube"))
        if (other.CompareTag("Asteroid"))
        {
            // Handle collision logic here
            Destroy(other.gameObject); // Destroy the asteroid
            Destroy(gameObject); // Destroy the bullet
        }
    }
}

/*public class BulletCollisionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}*/
