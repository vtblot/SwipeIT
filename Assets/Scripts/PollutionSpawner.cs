using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PollutionSpawner : MonoBehaviour {

    [Header("X Spawn Range")]
    [SerializeField] float xMax;
    [SerializeField] float xMin;
    [Header("Y Spawn Range")]
    [SerializeField] float yMax;
    [SerializeField] float yMin;

    [Space(10)]
    [SerializeField] GameObject pollutionPrefab;

    [Space(10)]
    [SerializeField] float waitingForNextSpawn = 1f;

    [Space(10)]
    [SerializeField] PlayerHealth playerHealth;

    private List<Vector2> positionsAlreadyGiven = new List<Vector2>();

    public static PollutionSpawner Instance = null;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
        StartCoroutine(Spawn());
	}
	
	IEnumerator Spawn()
    {
        float x, y;

        while(playerHealth.currentHealth >= 0 )
        {
            x = Random.Range(xMin, xMax);
            y = Random.Range(yMin, yMax);
            
            Vector2 pos = new Vector2(x, y);

            if(positionsAlreadyGiven != null && positionsAlreadyGiven.Contains(pos))
            {
                Debug.Log("Position Already Used");
                yield return 0;
            }

            positionsAlreadyGiven.Add(pos);

            Instantiate(pollutionPrefab, pos, transform.rotation);

            yield return new WaitForSeconds(waitingForNextSpawn);
        }
        yield break;
    }

    public void clearPosition(Vector2 pos)
    {
        if(positionsAlreadyGiven.Contains(pos))
        {
            positionsAlreadyGiven.Remove(pos);
        }
    }
}
