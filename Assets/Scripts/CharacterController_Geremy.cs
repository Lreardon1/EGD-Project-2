using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController_Geremy : MonoBehaviour
{
    public float moveSpeed = 2;
    public float jumpForce = 1;

    private Rigidbody2D rigidBd;

    // Start is called before the first frame update
    void Start()
    {
        rigidBd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //BasicMovement
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * moveSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigidBd.velocity.y) < 0.01f)
        {
            rigidBd.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        //Scalling debuging
        /*
        if(Input)

        */
    }
}
