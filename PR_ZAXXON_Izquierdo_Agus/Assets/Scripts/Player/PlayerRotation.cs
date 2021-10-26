using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float fuerzaX;
    public Rigidbody rb;
    float rotX;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        ShipRot();


    }
    void ShipRot()
    {
        float rotX = Input.GetAxis("Horizontal");
        rb.AddTorque(Vector3.back * fuerzaX * rotX);

    }
}
