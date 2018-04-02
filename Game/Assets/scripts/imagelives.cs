using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imagelives : MonoBehaviour {

    public Sprite life1;
    public Sprite life2;
    public Sprite life3;
   
	// Use this for initialization
	void Start () {
        


    }

    // Update is called once per frame
    void Update () {
        if (Lives.total_lifes == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = life3;
        }
        if (Lives.total_lifes == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = life2;
        }
        if (Lives.total_lifes == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = life1;
        }
    }
}
