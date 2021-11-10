using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HSScript : MonoBehaviour
{
    [SerializeField] Text HS_Text;
    // Start is called before the first frame update
    void Start()
    {
        HS_Text.text = "High Score: " + GameManager.highScore + " Seg.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
