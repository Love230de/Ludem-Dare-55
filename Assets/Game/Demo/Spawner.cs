using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject asteroid;
    [SerializeField] private float area;
    [SerializeField] private float amount;
    [SerializeField] private float spawnRate;
    private float nextFire;
    private void SpawnInArea()
    {
     

        for(int i = 0; i < amount;i++)
        {
            float newArea = Random.Range(-area, area);
            Vector3 pos = new Vector3(area * 0.5f,  area * 0.5f,transform.position.z);
            Instantiate(asteroid, pos, Quaternion.identity);
        }
    }

    private void Update()
    {
        if(nextFire > Time.time && GameController.instance.Escape)
        {
            SpawnInArea();
            nextFire = Time.time + spawnRate;
        }
    }
}
