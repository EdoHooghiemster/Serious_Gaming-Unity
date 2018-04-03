using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dialogue : MonoBehaviour {

    public Text  dialoguetext;

    // Use this for initialization
    void Start () {
        dialoguetext = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update () {
        if (NewBehaviourScript.scorewaarde >= 0)
        {
            dialoguetext.text = "I better type the words fast!";
        }
        if (NewBehaviourScript.scorewaarde >= 30)
        {
            dialoguetext.text = "I can't understand anything.";
        }
        if (NewBehaviourScript.scorewaarde >= 80 )
        {
            dialoguetext.text = "Have I ever not been right?";
        }
        if ( NewBehaviourScript.scorewaarde >= 130)
        {
        dialoguetext.text = "Now that we're men, I changed my underwear.";
        }
        if (NewBehaviourScript.scorewaarde >= 180)
        {
            dialoguetext.text = "I can't see my forehead";
        }
        if (NewBehaviourScript.scorewaarde >= 250)
        {
            dialoguetext.text = "I can feel my IQ Rising";
        }
        

    }
}
