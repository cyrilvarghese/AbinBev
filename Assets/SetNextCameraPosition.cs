using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNextCameraPosition : MonoBehaviour {
    public GameObject  CameraContainer;
    public GameObject NextGO;
    public Vector3  NextPostion;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void UpdatePosition()
    {
        CameraContainer.gameObject.GetComponent<Animator>().enabled = false;
        CameraContainer.transform.position = NextPostion;
        CameraContainer.transform.LookAt(NextGO.transform);
    }
}
