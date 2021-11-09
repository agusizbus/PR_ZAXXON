using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitGameScript : MonoBehaviour
{

    //VARIABLES INITGAME

    public float shipSpeed=100;
    private float gameSec = 0;
    public bool alive = true;
    public float gameLevel;
    


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LevelUp");
        
    }

    

    // Update is called once per frame
    void Update()
    {
        

    }

    public IEnumerator LevelUp()
    {
        for(; shipSpeed <= 500 ; shipSpeed += 5)
        {
           
            
            print(shipSpeed);
            yield return new WaitForSeconds(1f);
        }

        
    }
   

    public void Dead()
    {
        alive = false;
        shipSpeed = 0;
        print("lose");
        gameLevel = 0;
        SceneManager.LoadScene(0);
    }
}
