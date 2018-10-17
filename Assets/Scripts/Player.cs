using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] J1PlayerHealth playerHealth;
	[SerializeField] float collisionDamage = 10f;

	 void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("hit");
	}

	 void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("hitTrigg");
	}
}
