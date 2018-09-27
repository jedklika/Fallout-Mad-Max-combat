using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject Foe;
    public bool StopSpawning = false;
    public float SpawnTime;
    public float SpawnDelay;

    void Start()
    {
        InvokeRepeating("SpawnObject", SpawnTime, SpawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(Foe, transform.position, Quaternion.identity);
        StopSpawning = true;
        if (StopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
