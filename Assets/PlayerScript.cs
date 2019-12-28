using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Accel = 100;
        Rigidbody rb = this.GetComponent<Rigidbody> ();
        rb.AddForce(transform.right * Input.GetAxisRaw("Horizontal") * Accel, ForceMode.Impulse);
    }
}
