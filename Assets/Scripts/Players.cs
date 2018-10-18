using UnityEngine;
using UnityEngine.UI;


public class Players : MonoBehaviour {

	[SerializeField] PlayerHealth playerHealth;
	[SerializeField] float collisionDamage = 10f;

    [SerializeField] Slider lifeSlider;

    private void Awake()
	{
		playerHealth.currentHealth = 100f;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag.Equals("Enemy"))
        {
            //Le joueur n'était pas détecté en tant que mort quand il avait 0HP
            playerHealth.currentHealth -= collisionDamage;
            lifeSlider.value = playerHealth.currentHealth;

            if (playerHealth.currentHealth <= 0)
            {
                GameManager.instance.GameOver();
            }

        }
        if (gameObject.tag.Equals("Cleaner") && collision.gameObject.tag.Equals("Tache"))
        {
            PollutionSpawner.Instance.clearPosition(collision.gameObject.transform.position);

            Destroy(collision.gameObject);
        }
    }
}
