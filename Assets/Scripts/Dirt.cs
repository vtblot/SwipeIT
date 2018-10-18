using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dirt : MonoBehaviour {

    [SerializeField] private int maxDirt;
    [SerializeField] private Slider dirtSlider;
	// Use this for initialization
	void Start () {
        dirtSlider.maxValue = maxDirt;
        dirtSlider.value = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        int dirts = GameObject.FindGameObjectsWithTag("Tache").Length;

        if (dirts >= maxDirt)
        {
            GameManager.instance.GameOver();
        }

        dirtSlider.value = dirts;
    }

}
