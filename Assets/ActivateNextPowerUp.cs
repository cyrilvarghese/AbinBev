using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateNextPowerUp : MonoBehaviour {
    public GameObject NextHit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ActivateNextPwrUp()
    {
        if (NextHit != null)
        {
            NextHit.SetActive(true);
        }

    }
}
