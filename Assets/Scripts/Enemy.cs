using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	
	private GameObject cleaner;
	private Vector2 cleanerPos;
    private Rigidbody2D rgd;
	[SerializeField] float speed = 3f;

    [Header("When the enemy die")]
    [SerializeField] float pollutionRadius = 1f;
    [SerializeField] int numberOfPollutionToInstantiate;
    [SerializeField] GameObject tachePrefab;

	private void Start()
	{
        rgd = GetComponent<Rigidbody2D>();
        cleaner = GameObject.FindGameObjectWithTag("Cleaner");
		cleanerPos = cleaner.transform.position;
	}

	private void FixedUpdate()
	{
		cleanerPos = cleaner.transform.position;
		
		transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), cleanerPos, speed * Time.deltaTime);
        rgd.rotation = Quaternion.Euler(0, Mathf.Atan2(cleanerPos.x, cleanerPos.y) * Mathf.Rad2Deg, 0);

    }

    private void OnDestroy()
    {
        Vector3 pos;

        for (int i = 0; i<numberOfPollutionToInstantiate; i++)
        {
            pos = Random.insideUnitCircle * pollutionRadius;
            Instantiate(tachePrefab, pos, transform.rotation);
        }
    }

}
