using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollideLetter : MonoBehaviour {

    private int numLetters = 0;

    private Image ui_e, ui_a, ui_s, ui_y;

	// Use this for initialization
	void Start () {
        ui_e = GameObject.FindGameObjectWithTag("ImageE").GetComponent<Image>();
        ui_a = GameObject.FindGameObjectWithTag("ImageA").GetComponent<Image>();
        ui_s = GameObject.FindGameObjectWithTag("ImageS").GetComponent<Image>();
        ui_y = GameObject.FindGameObjectWithTag("ImageY").GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "E") {
            numLetters++;
            ui_e.enabled = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "A") {
            numLetters++;
            ui_a.enabled = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "S") {
            numLetters++;
            ui_s.enabled = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Y") {
            numLetters++;
            ui_y.enabled = true;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Goal") {
            if (numLetters == 4) {
                GameObject.Find("WinText").GetComponent<Text>().enabled = true;
                Destroy(GameObject.Find("Computer(Clone)"));
            }
        }
    }
}
