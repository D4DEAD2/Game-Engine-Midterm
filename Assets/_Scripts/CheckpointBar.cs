using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointBar : MonoBehaviour
{
    private const float maxCheck = 6.0f;
    public float numCheck;
    public Image checkBar;

    private void Start()
    {
        numCheck = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        checkBar.fillAmount = numCheck / maxCheck;
    }
}
