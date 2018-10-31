using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireTime = 0.5f;

    private bool isFiring = false;

    private void setFiring()
    {
        isFiring = false;
    }

    private void fire()
    {
        isFiring = true;
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        //if the game object has an audio source, it will play it when this method is executed
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        //invokes the setFiring method after the specified firing time
        Invoke("setFiring", fireTime);
    }

	

	void Update () {

        //if lmb is pressed and the gun is not already firing, the weapon is fired
		if( Input.GetMouseButton(0))
        {
            if (!isFiring)
            {
                fire();
            }
        }
	}
}
