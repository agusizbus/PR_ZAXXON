using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float fuerzaX;
    public Rigidbody rb;
    float rotX;
    InitGameScript initGameScript;


    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initGameScript = GameObject.Find("InitGameEmpty").GetComponent<InitGameScript>();

        

    }

    void FixedUpdate()
    {
        ShipRot();
        fuerzaX = initGameScript.shipSpeed / 10;
   


    }
    void ShipRot()
    {
        float rotX = Input.GetAxis("Horizontal");
        rb.AddTorque(Vector3.back * fuerzaX * rotX);
        
    }

}
