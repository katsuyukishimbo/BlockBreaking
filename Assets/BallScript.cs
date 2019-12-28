using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = 15;
        Rigidbody rb = this.GetComponent<Rigidbody> ();
        if (Input.GetButtonUp("Jump") && rb.velocity == new Vector3(0,0,0)){
            rb.AddForce((transform.forward + transform.right) * Speed, ForceMode.VelocityChange);
        }
    }

    void OnCollisionEnter () {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.velocity = rb.velocity.normalized * 30;

        // Vector3 tmp = GameObject.Find("Ball").transform.position;
        // if (Mathf.Abs(rb.velocity.y) < 5) {
        //     rb.velocity = new Vector3(tmp.x, tmp.y * 5, tmp.z);
        // }
        // if (Mathf.Abs(rb.velocity.x) < 5) {
        //     rb.velocity = new Vector3(tmp.x * 5, tmp.y, tmp.z);
        // }
 
    }
}
