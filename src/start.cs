using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start : MonoBehaviour
{
    public GameObject canon;
    public GameObject pausebutton;
    public GameObject fire;// Start is called before the first frame update
    public GameObject health;
    public GameObject slider;
    public GameObject startbutton;
    public GameObject highscore; 
    public GameObject store;
    public GameObject tankspawner;
    public GameObject aircraftspawner;
    public GameObject text;
    public GameObject livescore;
    public GameObject audio;
    public GameObject audio1;
    public GameObject tutorial;

    float timer = 0;
    bool b = false;
    bool b1 = false;
    void Start()
    {
        b = false;//PlayerPrefs.SetInt("tutorial", 0);
        b1 = false;//PlayerPrefs.SetInt("tutorial", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (b)
        {
            if (timer < 0.7f)
            {
                timer += Time.deltaTime;
            }
            else
            {
                canon.SetActive(true);
                pausebutton.SetActive(true);
                fire.SetActive(true);
                health.SetActive(true);
                slider.SetActive(true);
                if (PlayerPrefs.GetInt("tutorial", 0) == 0)
                {
                    tutorial.SetActive(true);
                    b1 = true;
                }
                else
                {
                    tutorial.SetActive(false);
                    tankspawner.SetActive(true);
                    aircraftspawner.SetActive(true);
                }
                startbutton.SetActive(false);
                text.SetActive(false);
                highscore.SetActive(false);
                store.SetActive(false);
                livescore.SetActive(true);
                audio.SetActive(false);
                audio1.SetActive(true);
                b = false;
                timer = 0;
            }
        }
        if (PlayerPrefs.GetInt("tutorial", 0) == 1 && b1)
        {
            b1 = false;
            tutorial.SetActive(false);
            tankspawner.SetActive(true);
            aircraftspawner.SetActive(true);

        }
    }
    public void startgame()
        {
       
        b = true;
        }

}
