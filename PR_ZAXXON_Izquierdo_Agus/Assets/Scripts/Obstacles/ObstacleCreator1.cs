using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentCreator : MonoBehaviour
{
    [SerializeField] GameObject column;
    [SerializeField] GameObject[] Environment;
    //[SerializeField] Transform initPos;
    public float intervalo;
    InitGameScript initGameScript;
    private Vector3 newPos;
    [SerializeField] float ObstacleDist = 100f;
    
    int level;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CreateEnvironment");

        //LLamar a un componente público en una línea
        initGameScript = GameObject.Find("InitGameEmpty").GetComponent<InitGameScript>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        intervalo =  ObstacleDist / initGameScript.shipSpeed ;
    }

   IEnumerator CreateEnvironment() 
    {
        

        while (true)
        {
            int randomNum;

            newPos = new Vector3(Random.Range(-20f, 20f), 25, (transform.position.z +600));

            randomNum = Random.Range(0, Environment.Length);

            Instantiate(Environment[randomNum], newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo/10);
        }
    }


}
