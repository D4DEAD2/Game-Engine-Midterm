using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public float dir = 1.0f;
    public float objSpeed = 2.0f;
    public bool updown = false;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (updown)
        {
            transform.position += (Vector3.forward * objSpeed * Time.deltaTime) * dir;
        }
        else
        {
            transform.position += (Vector3.right * objSpeed * Time.deltaTime) * dir;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player hit!");
        }
        else
        {
            dir = (dir * (-1.0f));
        }
    }
}
