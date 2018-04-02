using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idles_Patrick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Renderer rend = gameObject.GetComponent<Renderer>();

        if (NewBehaviourScript.scorewaarde >= 100)
        {
            rend.enabled = false;
        }
        if (NewBehaviourScript.scorewaarde >= 180)
        {
            rend.enabled = true;
        }
    }
}
