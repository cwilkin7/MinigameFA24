using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin_Spawner : MonoBehaviour
{
    public GameObject[] goblinPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            int GoblinDex = Random.Range(0, goblinPrefabs.Length);
            Instantiate(goblinPrefabs[GoblinDex], new Vector3(20, 2, 0), goblinPrefabs[GoblinDex].transform.rotation);
        }
    }
}
