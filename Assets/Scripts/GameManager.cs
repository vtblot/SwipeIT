using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	[SerializeField] GameObject endCanvas;
	[SerializeField] Score endScore;
    [SerializeField] Text endTextScore;

	private AudioManager audioManager;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
		endCanvas.SetActive(false);
		Time.timeScale = 1;
		audioManager = FindObjectOfType<AudioManager>();
		audioManager.Play("theme");
	}
	
	public void GameOver()
	{
		audioManager.Stop("theme");
		audioManager.Play("gameOver");
		endTextScore.text = endScore.currentScore.ToString();
		endCanvas.SetActive(true);
		Time.timeScale = 0;
    }
}
