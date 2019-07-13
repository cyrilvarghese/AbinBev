﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGameObjects : MonoBehaviour
{
    public GameObject[] ObjectToBeDeActivated;
    public GameObject[] ObjectToBeActivated;
    public GameObject CameraContainer;
    public GameObject NextGO;
    public Vector3 NextPostion;
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
        foreach (var item in ObjectToBeActivated)
        {
            item.SetActive(true);                   // deac.gameObject.GetComponent<Animator>().enabled = false;

        }
        foreach (var item in ObjectToBeDeActivated)
        {
            item.SetActive(false);                   // deac.gameObject.GetComponent<Animator>().enabled = false;

        }
        
    } 

    public void UpdatePosition()
    {
        if(CameraContainer!= null && NextPostion != null && NextGO != null)
        {
            CameraContainer.gameObject.GetComponent<Animator>().enabled = false;
            CameraContainer.transform.position = NextPostion;
            //`CameraContainer.transform.LookAt(NextGO.transform);
        }
       
    }
}