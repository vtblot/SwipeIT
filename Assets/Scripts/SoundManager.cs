using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

	public AudioClip clickSound, shootSound, cleanSound, deathSound;
	private AudioSource audioSrc;

	public static SoundManager Instance = null;

	void Awake()
	{
		if (Instance == null)
			Instance = this;
		else if (Instance != this)
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start()
	{
		clickSound = Resources.Load<AudioClip>("clickSound");
		shootSound = Resources.Load<AudioClip>("shootSound");
		cleanSound = Resources.Load<AudioClip>("cleanSound");
		deathSound = Resources.Load<AudioClip>("deathSound");

		audioSrc = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{

	}

	public void PlaySound(string clip)
	{
		switch (clip)
		{
			case "shoot":
				audioSrc.PlayOneShot(shootSound);
				break;
			case "click":
				audioSrc.PlayOneShot(clickSound);
				break;
			case "death":
				audioSrc.PlayOneShot(deathSound);
				break;
		}
	}

	// TO ADD 
	// SoundManagerScript.PlaySound("death");
}