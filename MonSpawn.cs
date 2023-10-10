using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonSpawn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime=0f;
    public float spawnDelay;
    

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        var spaceship = Lean.Pool.LeanPool.Spawn(spawnee, transform.position, transform.rotation);
        //Instantiate(spawnee, transform.position, transform.rotation);
        

    }

    // Update is called once per frame
    void Update()
    {

        
        //int randMon = Random.Range(0, monPrefabs.Length);
        //int randSpawnPoint = Random.Range(0, spawnPoints.Length);

        //Instantiate(monPrefabs[randMon], spawnPoints[randSpawnPoint].position, transform.rotation);
    }

    public void TakeDamage(float Damage)
    {
        if (gameObject != null)
        {
            // Do something  
            Destroy(gameObject);
        }
    }
}
