using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour {

    public float spawnTimer = 5.0f;
    public int maxEnemies = 5;
    public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Invoke("spawnObject", spawnTimer);
	}

    private void spawnObject()
    {
        if (maxEnemies < 5)
        {
            Instantiate(enemy);
        }
        
        
    }
}
