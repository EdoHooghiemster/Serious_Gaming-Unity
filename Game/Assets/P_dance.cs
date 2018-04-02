using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_dance : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.enabled = false;
        if (NewBehaviourScript.scorewaarde >= 130)
        {
            rend.enabled = true;
        }
        if (NewBehaviourScript.scorewaarde >= 180)
        {
            rend.enabled = false;
        }
    }
}
