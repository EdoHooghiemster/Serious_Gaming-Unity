using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_over : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void menu ()
    {
        SceneManager.LoadScene(0);
    }
	// Update is called once per frame
	void Update () {
        if (Lives.total_lifes == 0)
        {
            gameObject.SetActive(true);
        }
        else gameObject.SetActive(false);

	}
}
