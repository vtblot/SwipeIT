using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunMovement : MonoBehaviour {

	[SerializeField] float m_Speed;
	[SerializeField] float m_RotationSpeed;
	private Rigidbody2D rb2D;
	private Vector2 movement;
    public Boundary boundary;
	private TobiiCursor tc;
	private float angle;
	
	private void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
		tc = GetComponent<TobiiCursor>();
	}

	private void FixedUpdate()
	{
        float moveHorizontal = Input.GetAxis("GunHo");
        float moveVertical = Input.GetAxis("GunVer");

        movement = new Vector2(moveHorizontal, moveVertical);
        rb2D.velocity = movement * m_Speed;
		Vector2 tmp = Camera.main.ScreenToWorldPoint(tc.GetCursorPosition());
		Vector2 targetDir = tmp - (Vector2)transform.position;
		angle = Mathf.Atan2(tmp.y, tmp.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

		rb2D.position = new Vector2
        (
            Mathf.Clamp(rb2D.position.x, boundary.xMin, boundary.xMax), Mathf.Clamp(rb2D.position.y, boundary.yMin, boundary.yMax)
        );

    }
}
