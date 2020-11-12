using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    private Rigidbody playerRGDB;

    // Start is called before the first frame update
    void Start()
    {
        playerRGDB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");
        float lateral = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, lateral);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerRGDB.AddForce(movement * (speed/2));
        }
        else
        {
            playerRGDB.AddForce((movement * speed)/ Time.deltaTime);
        }
        
    }
}
