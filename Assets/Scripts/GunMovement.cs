using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMovement : MonoBehaviour {

	[SerializeField] private float m_Speed;
	private Rigidbody2D rb2D;
	private Vector2 movement;


	private void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}

	private void FixedUpdate()
	{
		float inputX = Input.GetAxis("Horizontal2");
		float inputY = Input.GetAxis("Vertical2");

		movement = new Vector2(
				m_Speed * inputX,
				m_Speed * inputY);

		rb2D.MovePosition(rb2D.position + movement * Time.fixedDeltaTime);

	}
}
