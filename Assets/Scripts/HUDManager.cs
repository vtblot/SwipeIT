using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour {

    [SerializeField] private Text textScore;
	[SerializeField] Score score;
	[SerializeField] Slider lifeSlider;
	public static HUDManager Instance = null;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != this)
            Destroy(gameObject);
		score.currentScore = 0;
    }

    public void AddScore()
    {
        score.currentScore += 1;
        textScore.text = score.currentScore.ToString();
    }

	public void UpdateLife(float newLife)
	{
		lifeSlider.value = newLife;
	}
}
