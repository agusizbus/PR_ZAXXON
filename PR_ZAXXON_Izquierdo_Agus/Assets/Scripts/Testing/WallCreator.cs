using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreator : MonoBehaviour
{
    [SerializeField] GameObject brick;
    //[SerializeField] Transform initPos;

    public float intervalo=1f;
    private Vector3 newPos;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CreateObstacles");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   IEnumerator CreateObstacles() 
    {
        while (true)
        {
            newPos = new Vector3(Random.Range(-20f, 20f), Random.Range(3f, 15f), Random.Range(20f, 40f));
            intervalo = Random.Range(0.5f, 2f);
            Instantiate(brick, newPos, Quaternion.identity);
            yield return new WaitForSeconds(intervalo);
        }
    }
}
