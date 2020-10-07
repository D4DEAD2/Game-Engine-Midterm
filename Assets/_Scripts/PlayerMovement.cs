using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public CharacterController p;
    public SphereCollider unfortunate;
    float jForce = 8.0f;
    float speed = 5.0f;
    float gravity = -9.4f;
    private Vector3 pVel;
    private bool _pGrounded;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
       //p = player.GetComponent<CharacterController>();
    }



    // Update is called once per frame
    void Update()
    {
        _pGrounded = p.isGrounded;
        //_pGrounded = ; // SETS GROUND TO TRUE OR FALSE
        if (pVel.y <= 0.0f && p.isGrounded)
        {
            pVel.y = 0.0f;
        }
        if (_pGrounded) // CHECKS IF IT IS TRUE OR NOT(DOES NOT EFFECT GROUNDED) 
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }

        if (Input.GetKeyDown("space") && _pGrounded)
        {
            pVel.y = jForce;
        }

        if (move != Vector3.zero)
        {
            player.transform.forward = move;
        }

        pVel.y += gravity * Time.deltaTime;
        p.Move((move * speed * Time.deltaTime) + (pVel * Time.deltaTime));
        
    }

}
