using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferCamera : MonoBehaviour {
    public GameObject NextCameraParent;
    public GameObject CameraContainer;
    public bool isTransferOnEnable;
    public bool localRectComponent;
    // Use this for initialization
    void OnEnable() {
        if(isTransferOnEnable)
        CameraContainer.transform.SetParent(NextCameraParent.transform, false);
    }
    public void TransferCameraToNextParent()
    {
        CameraContainer.transform.SetParent(NextCameraParent.transform, localRectComponent);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
