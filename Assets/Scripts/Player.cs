using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] PlayerHealth playerHealth;
	[SerializeField] float collisionDamage = 10f;

	private void Awake()
	{
		playerHealth.currentHealth = 100f;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log(playerHealth.currentHealth);
		if (playerHealth.currentHealth >= collisionDamage)
		{
			
			playerHealth.currentHealth -= collisionDamage;
		}
		else
		{
			GameManager.instance.GameOver();
		}
	}
}
