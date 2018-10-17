using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    [SerializeField] private float m_Speed;
	private Rigidbody2D rb2D;
	private Vector2 movement;


	private void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}

    private void FixedUpdate()
    {
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		movement = new Vector2(
				m_Speed * inputX,
				m_Speed * inputY);
		
		rb2D.MovePosition(rb2D.position + movement * Time.fixedDeltaTime);

	}
}
