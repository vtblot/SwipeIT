using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controler : MonoBehaviour {
    //[SerializeField] private Transform m_SpawnPoint;
    [SerializeField] private float m_Speed;

    private Vector2 movement;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal2");
        float inputY = Input.GetAxis("Vertical2");


        movement = new Vector2(
                m_Speed * inputX,
                m_Speed * inputY
            );
    }

    private void FixedUpdate()
    {
        GetComponent<Transform>().Translate(movement);

    }
}
