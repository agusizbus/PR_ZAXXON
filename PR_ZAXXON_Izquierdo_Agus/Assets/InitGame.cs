using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [SerializeField] string[] buttontext;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
