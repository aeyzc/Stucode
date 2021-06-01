using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterMover : MonoBehaviour
{
    float charSpeed = 10,jumpPower=17500;
    public GameObject charCamera;
    public Transform spawnPoint;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            if(Mathf.Abs(x) + Mathf.Abs(z) > 0.15f)
            {
                PlayerController.Instance.isWalking = true;
            }
            else PlayerController.Instance.isWalking = false;

        if (GameManager.Instance.isGameActive)
        {

            if (!PlayerController.Instance.isOnFloor && charSpeed > 0)
            {
                charSpeed -= Time.deltaTime * 1.5f;
            }
            else
            {
                charSpeed = 10;
            }

            x *= Time.deltaTime * charSpeed;
            z *= Time.deltaTime * charSpeed;
            


            
            transform.Translate(x, 0f, z);

        }
     

    }

    private void Update()
    {
        if (GameManager.Instance.isGameActive)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Reset();
            }

            if (PlayerController.Instance.isOnFloor && Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * jumpPower);


            }
        }
        
    }
    public void Reset()
    {
        transform.position = spawnPoint.position;
        transform.rotation = spawnPoint.rotation;
        rb.velocity = Vector3.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lav")
        {
            Reset();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "lav")
        {
            Reset();

        }
    }

}
