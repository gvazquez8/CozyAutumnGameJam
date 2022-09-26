using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{

    public GameObject customerPrefab;

    public GameObject[] spawnPoints;

    public float velocity;

    public bool spawnCustomer;

    private float spawnFrequency = 0.001f;

    // Update is called once per frame
    void Update()
    {
        foreach (var spawn in spawnPoints)
        {
            var sampleTime = Random.Range(0f, 1f);

            if (spawnFrequency > sampleTime)
            {
                var instance = Instantiate(customerPrefab, spawn.transform);
                // Get direction to move from spawn point
                Vector2 dir = spawn.GetComponent<SpawnerProperties>().GetDirectionVector();

                instance.GetComponent<EntityMovement>().velocity = velocity;
                instance.GetComponent<EntityMovement>().directionToMove = dir;
            }
        }
    }
}
