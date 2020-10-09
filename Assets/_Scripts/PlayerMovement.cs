using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//smoothdampangle

public class PlayerMovement : MonoBehaviour
{
    private CharacterController p;
    float jForce = 8.0f;
    float speed = 5.0f;
    float gravity = -9.4f;
    private Vector3 pVel;
    private bool _pGrounded;
    Vector3 move;
    bool death = false;

    //[SerializeField]
    public GameObject player;
    public Vector3 respawnPnt;

    // Start is called before the first frame update
    void Start()
    {
       p = player.GetComponent<CharacterController>();
       respawnPnt = new Vector3(18.5f, 5.0f, -20.0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Respawn")
        {
            death = true;
            p.enabled = false;
            player.transform.position = respawnPnt;
            Debug.Log(player.transform.position);
            p.enabled = true;
            death = false;
        }

        if (collision.gameObject.tag == "Checkpoint")
        {
            respawnPnt = collision.gameObject.transform.position;
        }
     }
    // Update is called once per frame
    void Update()
    {
        if (!death)
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
                //player.transform.forward = move; // Directs facing forward.
            }

            pVel.y += gravity * Time.deltaTime;
            p.Move((move * speed * Time.deltaTime) + (pVel * Time.deltaTime));
        }
    }

}
