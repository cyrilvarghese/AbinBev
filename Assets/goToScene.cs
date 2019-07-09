using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goToScene : MonoBehaviour {
    public string sceneName = "";
	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeScene()
    {

        StartCoroutine(goToSceneName(sceneName));
    }
    private IEnumerator goToSceneName(string name)
    {
     
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(name, LoadSceneMode.Single);

    }

}
