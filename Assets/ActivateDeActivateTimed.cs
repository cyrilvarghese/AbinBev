using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDeActivateTimed : MonoBehaviour {
    public GameObject[] ObjectToBeDeActivated;
    public GameObject[] ObjectToBeActivated;
    public float delay;
  
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivateAndDeActivateGO()
    {
        Invoke("ActDeactFunction", delay);
      

    }
    public void ActDeactFunction() {
        foreach (var item in ObjectToBeActivated)
        {
            item.SetActive(true);                   // deac.gameObject.GetComponent<Animator>().enabled = false;

        }
        foreach (var item in ObjectToBeDeActivated)
        {
            item.SetActive(false);                   // deac.gameObject.GetComponent<Animator>().enabled = false;

        }
    }

    
}
