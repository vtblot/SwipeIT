using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {


    public void LaunchLevel(string level)
    {
		FindObjectOfType<AudioManager>().Play("clickSound");
		SceneManager.LoadScene("Scenes/"+level);
    }

    public void QuitGame()
    {
        Application.Quit ();
    }

	public void GoToMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
