using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Transform initPos;
    public float speedX = 100;
    public float speedY = 100;

    //limites movimiento

    float limitR = 20f;
    float limitL = -20f;
    float limitUp = 20f;
    float limitBot = 0.2f;

    //Variable Bool movimiento

    bool inlimitY = false;
    bool inlimitX = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }



    void PlayerMovement ()
    {
        float posX = transform.position.x;
        float posY = transform.position.y;

        float desplX = Input.GetAxis("Horizontal");
        float desplY = Input.GetAxis("Vertical");

        //desplazamiento en X
        
        if (inlimitX)
        {

            transform.Translate(Vector3.right * desplX * Time.deltaTime * speedX, Space.World);
        }

        //limite en X

        if (posX > limitR && desplX > 0)
        {

            inlimitX = false;
        }

        else if (posX < limitL && desplX < 0)
        {
            inlimitX = false;
        }

        else

        {
            inlimitX = true;
        }


        //desplazamiento en y

        
        if (inlimitY)
        {

            transform.Translate(Vector3.up * desplY * Time.deltaTime * speedY, Space.World);
        }

        //LIMITE EN Y

        if (posY > limitUp && desplY > 0)
        {

            inlimitY = false;
        }

        else if (posY < limitBot && desplY < 0)
        {
            inlimitY = false;
        }

        else

        {
            inlimitY = true;
        }
        
        //rotacion
        float rot = desplX * 1.2f;
        transform.Rotate(Vector3.back * Time.deltaTime * rot * 200f);


    }


}


