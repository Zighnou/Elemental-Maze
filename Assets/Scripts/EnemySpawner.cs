using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0.0f, spawnRate);
    }

    void SpawnEnemy()
    {
        float spawnX = transform.position.x;
        float spawnY = transform.position.y;
        Vector3 spawnPos = new Vector3(spawnX, spawnY, 0.0f);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
