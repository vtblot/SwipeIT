using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour {

    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject ball;
    [SerializeField] int spawnTime;
    
    private int spawnPointIndex;

    // Use this for initialization
    void Start () {
        StartCoroutine(SpawnBall());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SpawnBall()
    {
        spawnPointIndex = Random.Range(0, spawnPoints.Length);

        GameObject enn = Instantiate(ball, spawnPoints[spawnPointIndex]);
        enn.GetComponent<BallMovement>().Conf(spawnPoints);
        yield return new WaitForSeconds(spawnTime);
    }
}
