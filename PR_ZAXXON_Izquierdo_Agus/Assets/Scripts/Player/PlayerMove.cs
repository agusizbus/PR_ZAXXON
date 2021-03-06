using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] Transform initPos;
    InitGameScript initGameScript;

    //limites movimiento

    float limitR = 70f;
    float limitL = -70f;
    float limitUp = 50f;
    float limitBot = 10f;

    //Variable Bool movimiento

    bool inlimitY = false;
    bool inlimitX = false;


    // Start is called before the first frame update
    void Start()
    {
        initGameScript = GameObject.Find("InitGameEmpty").GetComponent<InitGameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        



        //velocidad = espacio / tiempo
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

            transform.Translate(Vector3.right * desplX * Time.deltaTime * initGameScript.shipSpeed, Space.World);
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
            transform.Translate(Vector3.up * desplY * Time.deltaTime * initGameScript.shipSpeed, Space.World);
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
    }

    private void OnTriggerEnter(Collider other)
    {

       if (other.gameObject.layer == 6)
        {
       
            initGameScript.Dead();
        }
    }



}


