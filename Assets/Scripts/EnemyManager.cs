using UnityEngine;

public class EnemyManager : MonoBehaviour
{
	[SerializeField] J1PlayerHealth J1currentHealth;       
	[SerializeField] GameObject enemy;                
	[SerializeField] float spawnTime = 2f;            
	[SerializeField] Transform[] spawnPoints;         


	void Start()
	{
		InvokeRepeating("Spawn", spawnTime, spawnTime);
	}


	void Spawn()
	{
		if (J1currentHealth.currentHealth <= 0f)
		{
			Debug.Log(J1currentHealth.currentHealth);
			return;
		}
		
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		
		Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
