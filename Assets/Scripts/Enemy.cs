using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	private GameObject cleaner;
	private Vector2 cleanerPos;
    //private Rigidbody2D rgd;
	[SerializeField] float speed = 3f;

    [Header("When the enemy die")]
    [SerializeField] float pollutionRadius = 1f;
    [SerializeField] int numberOfPollutionToInstantiate;
    [SerializeField] GameObject[] tachePrefab;

	private void Start()
	{
        //rgd = GetComponent<Rigidbody2D>();
        cleaner = GameObject.FindGameObjectWithTag("Cleaner");
		cleanerPos = cleaner.transform.position;
	}

	private void FixedUpdate()
	{
		cleanerPos = cleaner.transform.position;
		
		transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), cleanerPos, speed * Time.deltaTime);

        float angle = Mathf.Atan2(cleanerPos.x - transform.position.x, cleanerPos.y - transform.position.y) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(-angle, Vector3.forward);


    }

    private void OnDestroy()
    {
        Vector3 pos;

		for (int i = 0; i < numberOfPollutionToInstantiate; i++)
		{
			pos = (Vector2)transform.position + Random.insideUnitCircle * pollutionRadius;
			Instantiate(tachePrefab[Random.Range(0, tachePrefab.Length)], pos, transform.rotation);
        }
    }

}
