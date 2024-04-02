using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject prefabEnemy;
    [SerializeField] List<Transform> spawnPoints;
    [SerializeField] Transform enemy;
    void Start()
    {
        StartCoroutine(enemySpawner());
        print("spaaaa");
    }
    IEnumerator enemySpawner() 
    {
        while (true)
        {
            Vector3 enemySpawn = spawnPoints[(Random.Range(0, spawnPoints.Count))].position;
            GameObject.Instantiate(prefabEnemy, enemySpawn, Quaternion.identity);

            yield return new WaitForSeconds(2f); 
        }
    }
}
