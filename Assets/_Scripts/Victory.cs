using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public Object plugins;

    private void OnTriggerEnter(Collider other)
    {
        DontDestroyOnLoad(plugins);
        SceneManager.LoadScene("End Scene");
    }

    public void ButtonPressed()
    {
        SceneManager.LoadScene("End Scene");
    }
}