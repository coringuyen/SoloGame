using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public float speed;
    float currentspeed;
    private Rigidbody rb;

    void Start()
    {
        currentspeed = speed;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed += 10;
            if (speed > 20)
                speed = 20;
        }
        else speed = currentspeed;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + movement);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 4, transform.position.z);
        }

        if (Input.GetKey(KeyCode.M))
        {
            transform.Rotate(new Vector3(transform.localRotation.x, transform.localRotation.y + 1, transform.localRotation.z));
            
        }

        
       
        //transform.Rotate(new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0));
    }
}
