using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheckpnt : MonoBehaviour
{
    public Material lit;

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<MeshRenderer>().material = lit;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
