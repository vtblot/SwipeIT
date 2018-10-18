using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag.Equals("Ground"))
		{
			Destroy(gameObject, 0);
		}
	}

<<<<<<< HEAD
=======
    [SerializeField] float speed;

    Vector2 force;

	// Use this for initialization
	void Start () {
        transform = GetComponent<Transform>();
        rigidbody = GetComponent<Rigidbody2D>();

        force = new Vector2(0.7f, 0.7f);
    }
	
	// Update is called once per frame
	void Update () {
        rigidbody.MovePosition(rigidbody.position + force * 3 * Time.fixedDeltaTime);
    }

    public void setShot(float x, float y, float speed)
    {
        this.speed = speed;
        force = new Vector2(x, y);
    }
    
>>>>>>> d22e562b129056c03d9dadff0b5a030cbc09dad5
}
