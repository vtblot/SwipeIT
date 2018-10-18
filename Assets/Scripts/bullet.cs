using UnityEngine;

public class Bullet : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag.Equals("Limits"))
		{
			Destroy(gameObject, 0);
		}

		if (collision.gameObject.tag.Equals("Enemy"))
		{
			Destroy(collision.gameObject, 0);
			Destroy(gameObject, 0);
		}
	}
}
