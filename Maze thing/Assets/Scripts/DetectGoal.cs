using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectGoal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Goal") {
            GameObject.Find("FishBowl").GetComponent<Image>().enabled = true;
            GameObject.Find("LoseText").GetComponent<Text>().enabled = true;
            Destroy(GameObject.Find("vThirdPersonCamera(Clone)"));
        }
    }
}
