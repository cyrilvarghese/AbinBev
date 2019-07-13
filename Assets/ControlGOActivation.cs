using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlGOActivation : MonoBehaviour
{
    public GameObject[] ObjectToBeDeActivated;
    public GameObject[] ObjectToBeActivated;
    public GameObject[] ObjectToBeDeActivatedOnHover;
    public GameObject[] ObjectToBeActivatedOnHover;
    public GameObject bottleCount;
    public GameObject CameraContainer;
    public Vector3 CameraPosition;
    public Vector3 CameraRotation;
    int currentCount = 0;
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
        //currentCount = PlayerPrefs.GetInt("currentXP");

        //PlayerPrefs.SetInt("currentXP", currentCount + 1);

        //bottleCount.GetComponent<Text>().text = (currentCount + 1).ToString() + "/7 bottles collected";



        //if (currentCount + 1 == 7)
        //{
        //    bottleCount.GetComponent<Text>().text = "All bottles collected!!!";
        //    bottleCount.GetComponent<Animator>().enabled = true;
        //}




    }
    public void ActivateAndDeActivateGOOnHover()
    {  
        foreach (var item in ObjectToBeActivatedOnHover)
        {
            item.SetActive(true);                   // deac.gameObject.GetComponent<Animator>().enabled = false;

        }
        foreach (var item in ObjectToBeDeActivatedOnHover)
        {
            item.SetActive(false);                   // deac.gameObject.GetComponent<Animator>().enabled = false;

        }

    }
    public void ActivateAndDeActivateGOOnHoverExit()
    {
        foreach (var item in ObjectToBeActivatedOnHover)
        {
            item.SetActive(false);                   // deac.gameObject.GetComponent<Animator>().enabled = false;

        }
        foreach (var item in ObjectToBeDeActivatedOnHover)
        {
            item.SetActive(true);                   // deac.gameObject.GetComponent<Animator>().enabled = false;

        }

    }

    public void PlayMissAudio()
    {
        AudioSource audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }

    public void UpdatePosition()
    {
        if (CameraContainer != null && CameraPosition != null)
        {
            CameraContainer.gameObject.GetComponent<Animator>().enabled = false;
            CameraContainer.transform.position = CameraPosition;
            //CameraContainer.transform.localEulerAngles = CameraRotation;
        }

       Invoke("ActivateAndDeActivateGO",1);

    }

}
