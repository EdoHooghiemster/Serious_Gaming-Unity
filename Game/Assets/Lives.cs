using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lives : MonoBehaviour {

    public static int total_lifes = 3;
    Text Lifes;

    // Use this for initialization
    void Start () {
        Lifes = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {
        Lifes.text = total_lifes + "x";
    }
}
