using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //[SerializeField] private Transform m_SpawnPoint;
    [SerializeField] private float m_Speed;

    private Vector2 movement;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");


        movement = new Vector2(
                m_Speed * inputX * Time.deltaTime,
                m_Speed * inputY * Time.deltaTime
			);
    }

    private void FixedUpdate()
    {
        GetComponent<Transform>().Translate(movement);

    }
}
