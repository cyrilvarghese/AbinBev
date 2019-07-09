using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAsync : MonoBehaviour {
    public string sceneName = "";
    // Use this for initialization
    void Start () {
        StartCoroutine(LoadYourAsyncScene(sceneName));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator LoadYourAsyncScene(string sceneName)
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        StartCoroutine(goToSceneName(sceneName));

    }

    private IEnumerator goToSceneName(string name)
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(name, LoadSceneMode.Single);

    }
}
