using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanerMovement : MonoBehaviour {
    
    [SerializeField] private float m_Speed;
	private Rigidbody2D rb2D;
	private Vector2 movement;
    public Boundary boundary;


    private void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector2(moveHorizontal, moveVertical);
        rb2D.velocity = movement * m_Speed;

        rb2D.position = new Vector2
        (
            Mathf.Clamp(rb2D.position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(rb2D.position.y, boundary.yMin, boundary.yMax)
        );
	}
}
