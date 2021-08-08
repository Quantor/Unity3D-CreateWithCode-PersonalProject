using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject powerUpPrefab;

    private float zEnemySpawn = 12;
    private float xSpawnRange = 16;
    private float zPowerupRange = 5;
    private float ySpawn = 0.75f;

    private float powerUpSpawnTime = 5;
    private float enemySpawnTime = 1;
    private float startDelay = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, enemySpawnTime);
        InvokeRepeating("SpawnPowerUp", startDelay, powerUpSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemyPrefabs.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zEnemySpawn);

        Instantiate(enemyPrefabs[randomIndex], spawnPos, enemyPrefabs[randomIndex].transform.rotation);
    }

    void SpawnPowerUp()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);
        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);
        Instantiate(powerUpPrefab, spawnPos, powerUpPrefab.transform.rotation);
    }
}
