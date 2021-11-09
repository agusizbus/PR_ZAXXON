using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] Image lives;
    [SerializeField] Sprite[] livesArray;
    [SerializeField] int vidas;
    int spritesPos = 0;



    // Start is called before the first frame update
    void Start()
    {
        vidas = livesArray.Length;
        lives.sprite = livesArray[spritesPos];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Chocar();
        }
    }

    public void Chocar()
    {

        vidas--;

        if(vidas > 0)
        {
            spritesPos++;
            lives.sprite = livesArray[spritesPos];
        }

        else
        {

            print("Morido");

        }
        

    }
}
