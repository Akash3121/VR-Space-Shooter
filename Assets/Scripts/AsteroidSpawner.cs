using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [Header("Size of the Spawner area")]
    public Vector3 spawnerSize;

    [Header("Rate of Spawn")]
    public float spawnRate = 1f;

    [Header("Model to spawn")]
    [SerializeField] private GameObject asteroidModel;

    private float spawnTimer = 0f;
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0, 1, 0, 0.5f);
        Gizmos.DrawCube(transform.position, spawnerSize);
    }

    private void Update()
    {
        spawnTimer += Time.deltaTime;
        
        if (spawnTimer > spawnRate) 
        {
            spawnTimer = 0;
            SpawnAsteroid();

        }
    }

    private void SpawnAsteroid()
    {
        //Random position for the asteroid
        Vector3 spawnPoint = transform.position + new Vector3(UnityEngine.Random.Range(-spawnerSize.x / 2, spawnerSize.x / 2),
                                                              UnityEngine.Random.Range(-spawnerSize.x / 2, spawnerSize.x / 2),
                                                              UnityEngine.Random.Range(-spawnerSize.x / 2, spawnerSize.x / 2));

        GameObject asteroid = Instantiate(asteroidModel, spawnPoint, transform.rotation);

        asteroid.transform.SetParent(this.transform);






    }

}
