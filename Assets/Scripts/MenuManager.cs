using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LaunchLevel(string level)
    {
        SceneManager.LoadScene("Scenes/"+level);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //Application.Quit ();
    }
}
