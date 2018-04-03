using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class WordDisplay : MonoBehaviour {

    
	public Text text;
	public float fallSpeed = 1f;

	public void SetWord (string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
	{
		text.text = text.text.Remove(0, 1);
		text.color = Color.red;
	}

	public void RemoveWord ()
	{
        NewBehaviourScript.scorewaarde += 10;
		Destroy(gameObject);
       
        
	}
  
	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        if (NewBehaviourScript.scorewaarde >= 250)
        {
            fallSpeed = 1.15f;
           
            transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        }
        if (transform.position.y <= -4.3)
                {   
                    Lives.total_lifes -= 1;
               
                    Destroy(gameObject);

                    Application.LoadLevel(Application.loadedLevel);
                }
        if (Lives.total_lifes == 0)
        {
            gameObject.SetActive(false);

        }

    }

}
