using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCreatureCreator : MonoBehaviour
{
    [SerializeField] GameObject[] itemSpawner;
    [SerializeField] GameObject[] enemySpawner;
    [SerializeField] int numberOfItems = 10;
    [SerializeField] int numberOfEnemies = 5;

    Vector2[] creatureSpawnLocation = {
    new Vector2(2.822998f, 6.76f),
    new Vector2(7.54f, 3.85f),
    new Vector2(64.20f, 16.45f),
    new Vector2(69.3f, 13.6f),
    new Vector2(64.52f, 10.55f),
    new Vector2(67.7f, 7.54f)};

    Vector2[] itemSpawnLocation = 
        {   new Vector2(67f, -5),
            new Vector2(45f, -7f),
            new Vector2(33.5f, 1.5f),
            new Vector2(36f, 13f),
            new Vector2(44f,17f),
            new Vector2(62f,6f),
            new Vector2(71.5f,18f)};

    void Start()
    {
        for (int i = 0; i < itemSpawnLocation.Length; i++)
        {
            Instantiate(itemSpawner[Random.Range(0, itemSpawner.Length - 1)], itemSpawnLocation[i], Quaternion.identity);
        }

        for(int i = 0; i < creatureSpawnLocation.Length; i++)
        {
            Instantiate(enemySpawner[Random.Range(0, enemySpawner.Length - 1)], creatureSpawnLocation[i], Quaternion.identity);
        }
    }
}
