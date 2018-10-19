using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class Players : MonoBehaviour {

	[SerializeField] PlayerHealth playerHealth;
	[SerializeField] float collisionDamage = 10f;
	[SerializeField] float repulsiveForce = 3f;

    private AudioManager audioManager;


	private void Start()
	{
		playerHealth.currentHealth = 100f;
		audioManager = FindObjectOfType<AudioManager>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag.Equals("Enemy"))
        {
            //Le joueur n'était pas détecté en tant que mort quand il avait 0HP
            playerHealth.currentHealth -= collisionDamage;
			HUDManager.Instance.UpdateLife(playerHealth.currentHealth);

			Vector3 dir = (transform.position - collision.transform.position).normalized;
			collision.transform.DOMove(collision.transform.position - dir * repulsiveForce, 0.5f);

            if (playerHealth.currentHealth <= 0)
            {
                GameManager.instance.GameOver();
            }

        }
        if (gameObject.tag.Equals("Cleaner") && collision.gameObject.tag.Equals("Tache"))
        {
			audioManager.Play("cleanSound");
			PollutionSpawner.Instance.clearPosition(collision.gameObject.transform.position);
            HUDManager.Instance.AddScore();
            Destroy(collision.gameObject);
        }

    }
}
