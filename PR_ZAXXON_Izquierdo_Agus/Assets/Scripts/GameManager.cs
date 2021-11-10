using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    InitGameScript initGameScript;
    [SerializeField] Slider volumeSlider;
    public static float volumeMusic = 5;
    public static float highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = GameManager.volumeMusic;
        initGameScript = GameObject.Find("InitGameEmpty").GetComponent<InitGameScript>();
    }

    

    // Update is called once per frame
    void Update()
    {
        highScore = initGameScript.timer;
    }

    public void CambiarVolumenMusica()
    {
        GameManager.volumeMusic = volumeSlider.value;
    }
}
