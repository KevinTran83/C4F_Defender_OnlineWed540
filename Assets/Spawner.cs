using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject target;
    public float spawnRange = 5;
    public float spawnTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", spawnTime);
    }

    void Spawn()
    {
        Vector3 spawnPos = transform.position
                         + new Vector3 ( Random.Range(-spawnRange, spawnRange),
                                         0,
                                         0
                                       );
        Instantiate(target, spawnPos, transform.rotation);
        Invoke("Spawn", spawnTime);
    }
}
