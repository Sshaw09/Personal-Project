using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMangerSecond : MonoBehaviour
{
    public GameObject enemyPrefab;
    float spawnRange = 7.5f;
    public int enemyCount;
    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateSpawnPosition", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateSpawnPosition()
    {
        float SpawnposX = Random.Range(-spawnRange, spawnRange);

        Vector3 SpawnPos = new Vector3(Random.Range(-spawnRange,spawnRange), spawnRange, -2);

        Instantiate(enemyPrefab, SpawnPos, enemyPrefab.transform.rotation);
    }

    void SpawnEnemyWave()
    {
        
        
    }
}
