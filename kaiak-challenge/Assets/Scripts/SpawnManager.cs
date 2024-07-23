using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float xMax = 15F;
    public float yEnemy = 4F;
    public float zEnemy = 8F;
    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }

    void SpawnEnemy(){
        float randomX = Random.Range(-xMax, xMax);
        int randomIndex = Random.Range(0, prefabs.Length);

        Vector3 spawnPos = new(randomX, yEnemy, zEnemy);

        Instantiate(prefabs[randomIndex], spawnPos, prefabs[randomIndex].transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
