using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{

    float speed;
    GameObject initGameObject;
    InitGameScript  initGameScript;

    // Start is called before the first frame update
    void Start()
    {
        initGameObject = GameObject.Find("InitGameEmpty");
        initGameScript = initGameObject.GetComponent<InitGameScript>();
        

    }

    // Update is called once per frame
    void Update()
    {
        speed = initGameScript.shipSpeed;
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
