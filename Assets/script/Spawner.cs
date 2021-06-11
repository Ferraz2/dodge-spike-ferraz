 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject spikePrefab;


    void Start()
    {
        InvokeRepeating("SpawnSpike", 1f, 1f);
    }

    private void SpawnSpike()
    {
        Vector3 position = new Vector3(Random.Range(-9.2f, 9.2f),3.5f,0);
        GameObject spawnSpike = Instantiate(spikePrefab);
        spawnSpike.transform.position = position;

    }
}