using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private AssetBundle loadedAssets;
    private string[] sceneDestinations;

    // Start is called before the first frame update
    void Start()
    {
        loadedAssets = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        sceneDestinations = loadedAssets.GetAllScenePaths();
    }

    private void OnGUI()
    {
        if(GUI.Button(new Rect(10, 10, 100, 30), "Change Scene")) 
        {
            SceneManager.LoadScene(sceneDestinations[0], LoadSceneMode.Single);
        }
    }
}
