using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 5f; 
    private float xInput;
    private float yInput;
    public float jumpForce = 5f;    // Start is called before the first frame update
    private UiManager Interfacemanager;

    void Start()
    {
        Interfacemanager = GameObject.Find("Canvas").GetComponent<UiManager>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(xInput, jumpForce, yInput);
        }
        
        Interfacemanager.geschwindigkeit = rb.velocity.magnitude;
        Interfacemanager.position1 = GameObject.Find("Ball").transform.position.x;
        Interfacemanager.position2 = GameObject.Find("Ball").transform.position.z;

    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

    }
    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, yInput) * moveSpeed);
        
    }
}
