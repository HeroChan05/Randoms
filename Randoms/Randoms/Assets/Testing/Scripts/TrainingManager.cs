using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainingManager : MonoBehaviour {

    GameObject text;

	// Use this for initialization
	void Start () {
        text = GameObject.FindGameObjectWithTag("SpeachBubble_Text");
        text.GetComponent<Text>().text = "Kill the Target!";
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
