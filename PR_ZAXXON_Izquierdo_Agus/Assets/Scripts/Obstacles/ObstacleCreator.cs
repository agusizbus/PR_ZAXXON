using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] GameObject column;
    [SerializeField] GameObject[] obstacles;
    //[SerializeField] Transform initPos;
    public float intervalo;
    InitGameScript initGameScript;
    private Vector3 newPos;
    [SerializeField] float ObstacleDist = 100f;
    
    int level;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CreateObstacles");

        //LLamar a un componente público en una línea
        initGameScript = GameObject.Find("InitGameEmpty").GetComponent<InitGameScript>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        intervalo =  ObstacleDist / initGameScript.shipSpeed ;
    }

   IEnumerator CreateObstacles() 
    {
        

        while (true)
        {
            int randomNum;

            newPos = new Vector3(Random.Range(-20f, 20f), 25, (transform.position.z +600));

            randomNum = Random.Range(0, obstacles.Length);

            Instantiate(obstacles[randomNum], newPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo * 1.5f);
        }
    }


}
