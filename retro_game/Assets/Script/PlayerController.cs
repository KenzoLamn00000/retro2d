using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private bool canMove;
    private Rigidbody2D theRB2D;

    // Start is called before the first frame update
    void Start()
    {
        theRB2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) {
            canMove = true;
        }
    }

    private void FixedUpdate() {
        MovePlayer();
        Jump();
    }

    void MovePlayer() {
        if(canMove) {
            theRB2D.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, theRB2D.velocity.y);
        }
    }

    void Jump() { 
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            theRB2D.velocity = new Vector2(theRB2D.velocity.x, jumpForce);
        }
    }
}
