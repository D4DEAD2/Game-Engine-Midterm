using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    CharacterController p;
    float jForce = 2.0f;
    float speed = 10.0f;
    float gravity = -9.4f;
    private Vector3 pVel;
    private bool _pGrounded;
    Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        p = player.GetComponent<CharacterController>();
    }


    // Update is called once per frame
    void Update()
    {
        _pGrounded = p.isGrounded; // SETS GROUND TO TRUE OR FALSE
        if(pVel.y < 0.0f && _pGrounded)
        {
            pVel.y = 0.0f;
        }
        if (_pGrounded) // CHECKS IF IT IS TRUE OR NOT(DOES NOT EFFECT GROUNDED) 
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }
        p.Move(move * speed * Time.deltaTime);

        if (move != Vector3.zero)
        {
            player.transform.forward = move;
        }

        if (Input.GetKeyDown("space"))
        {
            _pGrounded = p.isGrounded; // SETS GROUND TO TRUE OR FALSE(same command as before, shouldnt have to put this here.)
            if (_pGrounded)
            pVel.y += Mathf.Sqrt(jForce * -3.0f * gravity);
        }
        
        pVel.y += gravity * Time.deltaTime;
        p.Move(pVel * Time.deltaTime);
    }
}
