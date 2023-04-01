using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieManager : MonoBehaviour
{
    public Vector3[] spawnPoints;
    public GameObject zombiePrefab;
    public GameObject zombieParent;

    public float spawnTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnZombie(spawnTime, zombiePrefab));
        zombieParent = GameObject.FindWithTag("ZombieParent");
        spawnPoints = new Vector3[] { new Vector3(9.31f, -2.01f, -.02f), new Vector3(9.31f, -2.98f, -.02f) };
        
    }
    // void SpawnNewEnemy()
    // {
    //     // int spawnPointIndex = Random.Range(0, spawnPoints.Length);
    //     Instantiate(zombiePrefab, spawnPoints[0].transform.position, Quaternion.identity);
    // }
    private IEnumerator spawnZombie(float interval, GameObject enemy) {
        yield return new WaitForSeconds(interval);
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        GameObject newEnemy = Instantiate(enemy, spawnPoints[spawnPointIndex], Quaternion.identity, zombieParent.transform);
        // newEnemy.parent = zombieParent;
        StartCoroutine(spawnZombie(interval, enemy));
    }
    

}
