using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimationOnGO : MonoBehaviour
{
    public GameObject[] ObjectsToDeActivateAnimation;
    public GameObject[] ObjectsToActivateAnimation;
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivateAndDeActivateGOAnimation()
    {
        foreach (var item in ObjectsToDeActivateAnimation)
        {
            item.gameObject.GetComponent<Animator>().enabled = false;

        }
        foreach (var item in ObjectsToActivateAnimation)
        {
            item.gameObject.GetComponent<Animator>().enabled = true;

        }
    }
}
