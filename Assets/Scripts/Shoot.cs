using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;


public class Shoot : MonoBehaviour
{
	[SerializeField] Transform bulletSpawn;
	[SerializeField] GameObject bulletPrefab;
	[SerializeField] float bulletSpeed = 5f;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			GameObject b = Instantiate(bulletPrefab, bulletSpawn.position, transform.rotation);

			b.GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed, ForceMode2D.Impulse);

			FindObjectOfType<AudioManager>().Play("shootSound");
		}
	}


}

	
