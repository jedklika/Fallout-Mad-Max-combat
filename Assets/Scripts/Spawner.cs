using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject Foe;
    

    void Start()
    {
        StartCoroutine(SpawnEnemy());
        
    }

    
    IEnumerator SpawnEnemy()
    {
        float spawnCountdown;
        while (true)
        {
            spawnCountdown = 10.0f;
            while(spawnCountdown > 0)
            {
                Debug.Log("Spawn Time: " + spawnCountdown);
                yield return new WaitForSeconds(1.0f);
                spawnCountdown--;
            }
            GameObject enemy = Instantiate(Foe, transform.position, Quaternion.identity);
            spawnCountdown = 10.0f;
            while(spawnCountdown > 0)
            {
                Debug.Log("Remaining Time: " + spawnCountdown);
                yield return new WaitForSeconds(1.0f);
                spawnCountdown--;
            }
            Destroy(enemy);
        }
        
    }
}
