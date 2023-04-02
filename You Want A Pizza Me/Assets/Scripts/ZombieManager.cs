using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieManager : MonoBehaviour
{
    public Vector3[] spawnPoints;
    public GameObject zombiePrefab;
    public GameObject zombieParent;

    public float currentTime;
    public TimeText timeText;
    // public LevelManager levelManager;
    public float spawnTime = 3f;
    
    private IEnumerator coroutine;

    void Start()
    {
        spawnTime = Random.Range(1f, 3f);
        coroutine = spawnZombie(spawnTime, zombiePrefab);
        StartCoroutine(coroutine);
        zombieParent = GameObject.FindWithTag("ZombieParent");
        spawnPoints = new Vector3[] { new Vector3(9.31f, -2.01f, -.02f), new Vector3(9.31f, -2.98f, -.02f) };
        
    }

    void Update() {
        currentTime = timeText.currentTime;
        if (currentTime <= 1) {
            StopCoroutine(coroutine);
            SceneManager.LoadScene("WinScene");
        }
    }

    private IEnumerator spawnZombie(float interval, GameObject enemy) {
        yield return new WaitForSeconds(interval);
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        GameObject newEnemy = Instantiate(enemy, spawnPoints[spawnPointIndex], Quaternion.identity, zombieParent.transform);
        // newEnemy.parent = zombieParent;
        spawnTime = Random.Range(1f, 3f);
        coroutine = spawnZombie(spawnTime, zombiePrefab);
        StartCoroutine(coroutine);
    }
    

}
