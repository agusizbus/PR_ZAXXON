using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speedH;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        float desplY = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * desplY * Time.deltaTime * 100);

        float desplX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * desplX * Time.deltaTime * 100);





    }
}


