using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Variables necessary
    public GameObject enemyPrefab;
    float spawnRange = 7.5f;
    public int enemyCount;
    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Destroyer>().Length;
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float SpawnposX = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(SpawnposX, spawnRange, -2);

        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        
        for(int i= 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
