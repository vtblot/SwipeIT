using UnityEngine;

public class Bullet : MonoBehaviour {

	[SerializeField] PlayerHealth playerHealth;
	private AudioManager audioManager;

	private void Start()
	{
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag.Equals("Limits"))
		{
			Destroy(gameObject, 0);
		}

		if (collision.gameObject.tag.Equals("Enemy"))
		{
			audioManager.Play("deathSound");
			Destroy(collision.gameObject, 0);
			Destroy(gameObject, 0);
		}

		if (collision.gameObject.tag.Equals("Cleaner"))
		{
			HUDManager.Instance.UpdateLife(playerHealth.currentHealth -= 10);
			Destroy(gameObject, 0);
		}
	}
}
