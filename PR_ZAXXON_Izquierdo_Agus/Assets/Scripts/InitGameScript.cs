using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{

    //VARIABLES INITGAME

    public float shipSpeed=100;
    public bool alive = true;
    UIScript uiScriptDiff;
    int diffMultiplier = 1;
    public float timer = 0;
    //public int lifes = 3;
    




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LevelUp");
        StartCoroutine("Timer");
    }

    

    // Update is called once per frame
    void Update()
    {

        
    }

    public IEnumerator LevelUp()
    {
        
        for (; shipSpeed <= 500 ; shipSpeed += 5 * diffMultiplier)
        {
  
            //print(shipSpeed);
            yield return new WaitForSeconds(1f);
        }

        
    }

    public IEnumerator Timer()
    {
        for ( ; ; timer++)
        {
            print("llevas " + timer + " seg");
            yield return new WaitForSeconds(1f);
        }
    }
   

    public void Dead()
    {
        alive = false;
        shipSpeed = 0;
        print("lose");
        StopCoroutine("Timer");



        //lifes--;
        //if(lifes==0)
        //{
            SceneManager.LoadScene(4);
        //}

    }
}
