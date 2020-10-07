using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionScript : MonoBehaviour
{
    public PlayerMovement pain;
    private void OnCollisionStay(Collision collision)
    {
       // pain._pGrounded = true;
    }
}
