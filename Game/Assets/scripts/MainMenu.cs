using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void play () {
        SceneManager.LoadScene(1);
        Lives.total_lifes = 3;
	}
	
	public void menu ()
    {
        SceneManager.LoadScene(0);
    }

    public void quitgame()
    {
        Application.Quit();
    }
}
