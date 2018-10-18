using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {

    Transform transform;
    Rigidbody2D rigidbody;

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
    
}
