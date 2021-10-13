using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] GameObject brick;
    //[SerializeField] Transform initPos;

    public float intervalo;

    InitGameScript initGameScript;

    private Vector3 newPos;

    [SerializeField] float ObstacleDist = 100f;
    
   



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CreateObstacles");

        //LLamar a un componente público en una línea
        initGameScript = GameObject.Find("InitGameEmpty").GetComponent<InitGameScript>();

        //LLamar a un componente público en dos líneas
        //initGameObject = GameObject.Find("InitGameEmpty");
        //initGameScript = initGameObject.GetComponent<InitGameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        intervalo = ObstacleDist / initGameScript.shipSpeed;
    }

   IEnumerator CreateObstacles() 
    {
        

        while (true)
        {
            //intervalo = ObstacleDist / initGameScript.shipSpeed;

            newPos = new Vector3(Random.Range(-20f, 20f), Random.Range(3f, 20f), (transform.position.z +300));

            //INTERVALO ALEATORIO
            //intervalo = Random.Range(0.2f, 0.5f);

            

            Instantiate(brick, newPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);
        }
    }


}
