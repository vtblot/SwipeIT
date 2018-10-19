using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyManager : MonoBehaviour
{
	[SerializeField] PlayerHealth J1currentHealth;       
	[SerializeField] GameObject enemy;                
	[SerializeField] float spawnTime = 2f;            
	[SerializeField] Transform[] spawnPoints;
	private List<GameObject> enemies = new List<GameObject>();
	private int spawnPointIndex;


	void Start()
	{
		StartCoroutine(Spawn());
	}

	IEnumerator Spawn()
	{

		spawnPointIndex = Random.Range(0, spawnPoints.Length);

		GameObject enn = Instantiate(enemy, spawnPoints[spawnPointIndex]);

		enemies.Add(enn);

		yield return new WaitForSeconds(spawnTime);

		while (enabled)
		{
			spawnPointIndex = Random.Range(0, spawnPoints.Length);

			 enn = Instantiate(enemy, spawnPoints[spawnPointIndex]);

			enemies.Add(enn);

			yield return new WaitForSeconds(spawnTime);
		}

        yield break;
    }
	
}
