using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {
    public Camera MainCamera;
    // Use this for initialization
    void Start () {
        transform.LookAt(MainCamera.transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
