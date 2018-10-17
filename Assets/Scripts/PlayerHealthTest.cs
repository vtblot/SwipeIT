using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthTest : MonoBehaviour {
    [SerializeField] private Slider lifeField;
    [SerializeField] PlayerHealth J1currentHealth;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
    }

    void FixedUpdate()
    {
        lifeField.value = J1currentHealth.currentHealth;
    }

    public void LoseLife()
    {
        J1currentHealth.currentHealth -= 10f;
    }

    public void GainLife()
    {
        J1currentHealth.currentHealth += 10f;
    }
}
