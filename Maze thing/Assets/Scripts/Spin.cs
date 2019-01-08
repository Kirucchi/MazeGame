using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.up, 10f * Time.deltaTime);
        Collider collider = GetComponent<Collider>();
        transform.RotateAround(collider.bounds.center, Vector3.up, 80.0f * Time.deltaTime);
	}
}
