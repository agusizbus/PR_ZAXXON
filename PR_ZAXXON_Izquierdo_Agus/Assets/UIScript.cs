using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text buttonText;
    public Image lifeSprite;
    public bool diffhard = false;
    public bool musicPlays = true;
    InitGameScript initGameScript;
    // Start is called before the first frame update
    void Start()
    {
        initGameScript = GameObject.Find("InitGameEmpty").GetComponent<InitGameScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {        
        SceneManager.LoadScene(1);
      
    }

    public void ConfigMenu()
    {
        SceneManager.LoadScene(2);
    }

    public void HSMenu()
    {
        SceneManager.LoadScene(4);
    }

    public void InitMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeTextDifficulty()
    {

        GameObject.Find("DiffButton").GetComponentInChildren<Text>();

    }

    public void DifficultySwitch()
    {
        if (diffhard)
        {
            diffhard = false;
        }

        else { diffhard = true; }


        switch (diffhard)
        {
            case true:
                buttonText.text = "Hard";
                break;

            case false:
                buttonText.text = "Normal";
                break;
        }

    }

    public void MusicSwitch()
    {
        if (musicPlays)
        {
            musicPlays = false;
        }

        else { musicPlays = true; }


        switch (musicPlays)
        {
            case true:
                buttonText.text = "On";
                break;

            case false:
                buttonText.text = "Off";
                break;
        }

    }


}
