using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Applied to Empty named SpawnManager
public class spawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public gameManager gameManager;

    private float spawnPosY = (float).64;

    private float startDelay = 0f;
    private float spawnIntervalMin = .2f;
    private float spawnIntervalMax = .4f;

    private float[] spawnZPos = {6, 2, (float)-1.5, (float)-5.5};

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, Random.Range(spawnIntervalMin, spawnIntervalMax));

    }

    // Spawn random enemy at random x position at top of play area
    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        int zPosIndex = Random.Range(0, 3);
        // Generate random enemy index and random spawn position
        Vector3 spawnPos = new Vector3(-21, spawnPosY, spawnZPos[zPosIndex]);
        if (gameManager.gameActive == true)
        {
            // instantiate enemy at random spawn location
            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[0].transform.rotation);
        }
    }
}
