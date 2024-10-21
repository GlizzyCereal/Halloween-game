using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] candies;
    public int numberOfPrefabs = 4;
    public float minX = -7.25f;
    public float maxX = 7.25f;
    public float spawnInterval = 5f;

    private float nextSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnPrefabs();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnPrefabs()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            GameObject prefabToSpawn = candies[Random.Range(0, candies.Length)];
            Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), 3.85f, Random.Range(minX, maxX));
            Instantiate(prefabToSpawn, randomPosition, Quaternion.identity);
        }
    }
}
