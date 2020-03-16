using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectCreator : MonoBehaviour
{
    [SerializeField] GameObject[] itemSpawner;
    [SerializeField] GameObject[] enemySpawner;
    [SerializeField] int numberOfItems = 10;
    [SerializeField] int numberOfEnemies = 5;

    Vector2 []itemSpawnLocation = { new Vector2(-13f, -3f),
                                    new Vector2(5f, -1.5f),
                                    new Vector2(15f, 6f),
                                    new Vector2(22f, 11f),
                                    new Vector2(0f,9f)};

    void Start()
    {
        for(int i = 0; i < itemSpawnLocation.Length; i++)
        {
            Instantiate(itemSpawner[Random.Range(0, itemSpawner.Length - 1)], itemSpawnLocation[i], Quaternion.identity);
        }

        /*
        for (int i = 0; i < numberOfItems; i++)
        {
            spawnLocation.x = Random.Range(-23, 16);
            spawnLocation.y = Random.Range(-7, 7);
            Instantiate(itemSpawner[Random.Range(0, itemSpawner.Length)], spawnLocation, Quaternion.identity);
        }
        for (int i = 0; i < numberOfEnemies; i++)
        {
            spawnLocation.x = Random.Range(-23, 16);
            spawnLocation.y = Random.Range(-7, 7);
            Instantiate(enemySpawner[Random.Range(0, enemySpawner.Length)], spawnLocation, Quaternion.identity);
        }*/

    }
}
