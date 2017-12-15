using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BubbleChat : MonoBehaviour {

    GameObject Player;
    GameObject SpeachBubble;
    GameObject SpeachBubble_Text;

    [Tooltip("Minimum Distance from Object")]
    float minDist = 0.2f;
    [Tooltip("Maximum Distance from Object")]
    float maxDist = 5;

    bool inRange;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        SpeachBubble = GameObject.FindGameObjectWithTag("SpeachBubble");
        SpeachBubble_Text = GameObject.FindGameObjectWithTag("SpeachBubble_Text");

        SpeachBubble.SetActive(false);
        SpeachBubble_Text.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if(Vector3.Distance(transform.position, Player.transform.position) >= minDist)
        {
            SpeachBubble.SetActive(false);
            SpeachBubble_Text.SetActive(false);
			inRange = false;
        }

        if(Vector3.Distance(transform.position, Player.transform.position) <= maxDist)
        {
            SpeachBubble.SetActive(true);
            SpeachBubble_Text.SetActive(true);
            inRange = true;
        }

        if(inRange && Input.GetKey(KeyCode.Space))
        {
			SceneManager.LoadScene("Testing_Simulation");
        }
    }
}
