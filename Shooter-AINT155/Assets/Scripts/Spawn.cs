using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    //the prefab that will be instantiated by the script
    public GameObject prefabToSpawn;

    //used to adjust the angle of the object when it is instantiated
    public float adjustmentAngle = 0.0f;


	public void spawnObject()
    {
        Vector3 rotationInDegrees = transform.eulerAngles;
        rotationInDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);

        Instantiate(prefabToSpawn, transform.position, rotationInRadians);
    }

    
}
