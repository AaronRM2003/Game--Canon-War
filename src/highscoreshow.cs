using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoreshow : MonoBehaviour
{
    public Text highscoretext;
    
    // Start is called before the first frame update
    void Start()
    {
        highscoretext.text = PlayerPrefs.GetInt("highscore", 0) + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
