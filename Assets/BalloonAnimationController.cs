using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonAnimationController : MonoBehaviour {
    public Animator SunroofAnimator;
	// Use this for initialization
	void Start () {
      

    }
    private void OnEnable()
    {
         SunroofAnimator.GetComponent<Animator>().Play("balloon-up"); 
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("1"))
        {
            
        }
		
	}
}
