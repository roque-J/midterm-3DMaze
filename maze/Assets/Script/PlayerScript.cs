using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed;
    public RigidBody theRB;
    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<RigidBody>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector3(Input.GetAxis("Horizontal")* moveSpeed, theRB.velocity.y, Input.GetAxis("Vertial") * moveSpeed);
        if(Input.GetButtonDown("Jump")){
            theRB.velocity = new Vector3(theRB.velocity.x, jumpforce, theRB.velocity.z);
        }
    }
}
