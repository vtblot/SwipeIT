using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] J1PlayerHealth playerHealth;
	[SerializeField] float collisionDamage = 10f;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (playerHealth.currentHealth > collisionDamage)
		{
			Debug.Log("hit");
			playerHealth.currentHealth -= collisionDamage;
		}
		else
		{
			GameManager.instance.GameOver();
		}
	}
}
