using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class wave {
    public int EnemiesPerWave;
    public GameObject Enemy;
}
public class EnemyManager : MonoBehaviour {

    public wave[] waves;
    public Transform[] SpawnPoints;
    public float SpawnTime = 2f;

    private int totalEnemiesInWave;
    private int enemiesLeft;
    private int spawnedEnemies;

    private int currentWave;
    private int totalWaves;

	// Use this for initialization
	void Start () {

        currentWave = -1;
        totalWaves = waves.Length - 1;

        StartNextWave();

	}

    void StartNextWave()
    {
        currentWave++;

        //end game or win
        if (currentWave > totalWaves)
        {
            return;
        }

        totalEnemiesInWave = waves[currentWave].EnemiesPerWave;
        enemiesLeft = 0;
        spawnedEnemies = 0;

        //StartCoroutine(SpawnEnemies());
    }
    /*
    IEnumerator SpawnEnemies()
    {

    }
    */

    // Update is called once per frame
    void Update () {
		
	}
}
