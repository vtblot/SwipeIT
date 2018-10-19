using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	private AudioManager audioManager;
	// Use this for initialization
	void Start () {
		audioManager = FindObjectOfType<AudioManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LaunchLevel(string level)
    {
		FindObjectOfType<AudioManager>().Play("clickSound");
		SceneManager.LoadScene("Scenes/"+level);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit ();
    }

	public void GoToMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
