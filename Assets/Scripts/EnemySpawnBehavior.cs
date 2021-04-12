using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehavior : MonoBehaviour
{
    public float XMax;
    public float XMin;

    public float TimeBetweenSpawn;
    public bool StopSpawning;

    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    public IEnumerator SpawnEnemies()
    {
        while (!StopSpawning)
        {
            float RandX = Random.Range(XMax, XMin);

            Vector3 Spawn = new Vector3(RandX, transform.position.y, transform.position.z);

            GameObject enemy = Instantiate(Enemy.gameObject, Spawn, new Quaternion());
            EnemyMovementBehavior MoveEnemy = enemy.GetComponent<EnemyMovementBehavior>();
            MoveEnemy.StartCos = Random.Range(-1, 1);

            yield return new WaitForSeconds(TimeBetweenSpawn);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
