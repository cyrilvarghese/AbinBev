using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour {
    public GameObject finalEffect;
    //public GameObject rulesText;
    //public GameObject finalText;
    //public GameObject puzzle;
    //public GameObject characters;
    //public GameObject finalPuzzle;

    // Use this for initialization
    void Start () {
            UnityEngine.XR.XRSettings.eyeTextureResolutionScale = 1.50f;
        PlayerPrefs.SetInt("currentXP", 0);

    }

    // Update is called once per frame
    void Update () {
       int currentCount = PlayerPrefs.GetInt("currentXP");
      
        GameObject[] brandBottles = GameObject.FindGameObjectsWithTag("global");
//        if (brandBottles.Length ==0 && puzzle.activeSelf==true)
//        {
//            finalEffect.gameObject.GetComponent<Animator>().enabled = true;
//            rulesText.SetActive(false);
//            puzzle.SetActive(false);
//            finalText.SetActive(true);
//            characters.SetActive(false);
//}
    }


}
