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


	void Start()
	{
		StartCoroutine(Spawn());
	}

	IEnumerator Spawn()
	{

        SpawnZombie();
        yield return new WaitForSeconds(spawnTime);

        while (enabled)
		{

            int randSpawn = Random.Range(0, 10);

            if(randSpawn <= 6)
            {
                SpawnZombie();
            }
            else if((randSpawn  == 10))
            {
                SpawnSideZombie();
            }
            else
            {
                SpawnMoreZombie();
            }

            yield return new WaitForSeconds(spawnTime);
        }

        yield break;
    }

    private void SpawnZombie()
    {
        int spawnPointIndex;

        spawnPointIndex = Random.Range(0, spawnPoints.Length);
        GameObject enn = Instantiate(enemy, spawnPoints[spawnPointIndex]);
        enemies.Add(enn);
    }

    private void SpawnMoreZombie()
    {
        int spawnPointIndex;

        spawnPointIndex = Random.Range(0, spawnPoints.Length);
        GameObject enn1 = Instantiate(enemy, spawnPoints[spawnPointIndex]);
        enemies.Add(enn1);

        spawnPointIndex = Random.Range(0, spawnPoints.Length);
        GameObject enn2 = Instantiate(enemy, spawnPoints[spawnPointIndex]);
        enemies.Add(enn2);
    }

    private void SpawnSideZombie()
    {
        int rand = Random.Range(0, 3) + 1;
        int sideSpawn = spawnPoints.Length / rand;


        GameObject enn1 = Instantiate(enemy, spawnPoints[sideSpawn - 1]);
        enemies.Add(enn1);
        
        GameObject enn2 = Instantiate(enemy, spawnPoints[sideSpawn]);
        enemies.Add(enn2);
        
        GameObject enn3 = Instantiate(enemy, spawnPoints[sideSpawn + 1]);
        enemies.Add(enn3);
        
        GameObject enn4 = Instantiate(enemy, spawnPoints[sideSpawn + 2]);
        enemies.Add(enn4);

    }

}
