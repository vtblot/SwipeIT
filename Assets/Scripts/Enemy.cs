using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private GameObject cleaner;
	private Vector3 cleanerPos;
	[SerializeField] float speed = 3f;

	private void Start()
	{
		cleaner = GameObject.FindGameObjectWithTag("Cleaner");
		cleanerPos = cleaner.transform.position;
	}

	private void Update()
	{
		cleanerPos = cleaner.transform.position;

		transform.LookAt(cleanerPos);
		transform.Rotate(new Vector3(0, -90, 0), Space.Self);
		transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
		
	}

}
