using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Spawner : MonoBehaviour
{
    public GameObject[] goblinPrefabs;
    private float spawnRangeX = 1;
    private float spawnPosY = 0;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnThatGoblin", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }    
    void SpawnThatGoblin()
    {
        {
            Vector3 spawnPos = new Vector3(25, spawnPosY, Random.Range(-spawnRangeZ, spawnRangeZ));
            int GoblinDex = (int)Random.Range(spawnRangeX, goblinPrefabs.Length);
            Instantiate(goblinPrefabs[GoblinDex],spawnPos, goblinPrefabs[GoblinDex].transform.rotation);
        }
    }
}
