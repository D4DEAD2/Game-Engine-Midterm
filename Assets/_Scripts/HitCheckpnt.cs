using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheckpnt : MonoBehaviour
{
    private bool triggered = false;
    public Material lit;
    public ManagerPlugin pMngr;
    public CheckpointBar checkBar;
    float lastTime;

    void Start()
    {
        lastTime = Time.time;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !triggered)
        {
            triggered = true;
            checkBar.numCheck = checkBar.numCheck + 1.0f;
            gameObject.GetComponent<MeshRenderer>().material = lit;
            float currentTime = Time.time;
            float checkpointTime = currentTime - lastTime;
            lastTime = currentTime;

            pMngr.SaveTimer(checkpointTime);
        }
    }
}
