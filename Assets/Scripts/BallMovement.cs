using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    private Transform[] spawnPoints;
    [SerializeField] float speed;
    private bool isConf = false;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (isConf)
        {
            int endPoint = 0;
            int spawnPointIndex = 0;
            int count = 0;
            foreach(Transform sp in spawnPoints)
            {
                if (sp == transform)
                {
                    spawnPointIndex = count;
                }

                count++;
            }

            if (spawnPointIndex + 4 < spawnPoints.Length)
            {
                endPoint = spawnPointIndex + 4;
            }
            else
            {
                endPoint = spawnPointIndex - 4;
            }

            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), new Vector2(spawnPoints[endPoint].position.x, spawnPoints[endPoint].position.y), speed * Time.deltaTime);
            float dist = Vector2.Distance(new Vector2(transform.position.x, transform.position.y), new Vector2(spawnPoints[endPoint].position.x, spawnPoints[endPoint].position.y));
            if (dist < 1)
            {
                Destroy(gameObject);
            }
        }

        
    }

    public void Conf(Transform[] transforms)
    {
        spawnPoints = transforms;
        isConf = true;
    }
}
