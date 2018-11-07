using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class EnemySpawnedEvent : UnityEvent<Transform>
{

}

public class FindTag1 : MonoBehaviour {

    public GameObject player;
    public EnemySpawnedEvent onSpawn;

    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        onSpawn.Invoke(player.transform);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
