using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateRight : MonoBehaviour
{

    public float speed;
    private Rigidbody rb;
    public bool isGround;
    public float jumpForce = 2.0f;
    public Vector3 jump;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = transform.up * 2f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(1f, 0, 0);
        rb.AddForce(movement * speed);

        if (isGround)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            timer += Time.deltaTime;
            isGround = false;
            if (timer == 1f)
            {
                isGround = false;
            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;

        }
    }
}