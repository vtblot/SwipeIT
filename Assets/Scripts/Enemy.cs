using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	private GameObject cleaner;
	private Vector2 cleanerPos;
	[SerializeField] float speed = 3f;

	private void Start()
	{
		cleaner = GameObject.FindGameObjectWithTag("Cleaner");
		cleanerPos = cleaner.transform.position;
	}

	private void FixedUpdate()
	{
		cleanerPos = cleaner.transform.position;
		
		transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), cleanerPos, speed * Time.deltaTime);

	}

}
