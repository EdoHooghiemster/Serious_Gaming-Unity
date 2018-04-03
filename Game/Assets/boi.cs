using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Lives.total_lifes == 0)
        {
            gameObject.SetActive(false);
        }
        else gameObject.SetActive(true);
	}
}
