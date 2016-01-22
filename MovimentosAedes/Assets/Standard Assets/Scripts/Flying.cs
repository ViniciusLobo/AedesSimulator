using UnityEngine;
using System.Collections;

public class Flying : MonoBehaviour {
    public Rigidbody rb;

    void FlyE()
    {
        rb.AddForce(0, 200f, 0);
        //rb.AddForceAtPosition (new Vector3(1,1,1), 1f, 1f);
        //transform.position = new Vector3(0,1f,0);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("FlyE", 0, 0.1f);
    }
    void FixedUpdate ()
    {
        rb.AddForce(Physics.gravity*3);
        
    }
}
