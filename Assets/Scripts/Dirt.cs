using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dirt : MonoBehaviour {

    [SerializeField] private int maxDirt;
    private Slider dirtSlider;
	// Use this for initialization
	void Start () {
		dirtSlider = GetComponent<Slider>();
		dirtSlider.maxValue = maxDirt;
        dirtSlider.value = 0;
	}
	
	// Update is called once per frame
	void Update () {
		int dirts = GameObject.FindGameObjectsWithTag("Tache").Length;

		if (dirts >= maxDirt)
		{
			GameManager.instance.GameOver();
		}

		dirtSlider.value = dirts;
		
	}

}
