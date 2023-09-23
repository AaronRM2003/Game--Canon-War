using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class health : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public int cnt=0;

    public Slider s;
    public GameObject canon;
    public GameObject pausebutton;
    public GameObject fire;// Start is called before the first frame update
    public GameObject health1;
    public GameObject slider;
    public GameObject gameovertext;
    public GameObject tankspawner;
    public GameObject aircraftspawner;
    public GameObject mainmenu;
    public GameObject resume;
    public Text livescore;
    public Text score;
    public GameObject livescore1;
    public int totalscore;
    public Text money;
    public power p;
    public GameObject c;
    bool b;
    bool b1;
    public GameObject canon1;
    public GameObject canon2;
    public GameObject canon3;
    public ads adunitid;
    public GameObject audio;
    public GameObject image;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        s.value = 1;
        b = true;
        b1 = true;
        p = c.GetComponent<power>();
        totalscore = PlayerPrefs.GetInt("totalscore1", 0);
        money.text = totalscore + "$";
        adunitid = GameObject.FindGameObjectWithTag("ad").GetComponent<ads>();
    }

    // Update is called once per frame
    void Update()
    {
        if (s.value < 0.045f)
        {
            gameover();
          
        }
        if (PlayerPrefs.GetInt("canon", 0) == 0)
        {
            canon1.SetActive(true);
            canon2.SetActive(false);
            canon3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("canon", 0) == 1)
        {
            canon1.SetActive(false);
            canon2.SetActive(true);
            canon3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("canon", 0) == 2)
        {
            canon1.SetActive(false);
            canon2.SetActive(false);
            canon3.SetActive(true);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        cnt += 1;
        if (PlayerPrefs.GetInt("tutorial", 0) == 1)
        {
            if (b1)
            {
                s.value = 1;
                b1 = false;
            }
            if (s.value >= 0.03f)
            {
                if (PlayerPrefs.GetInt("canon", 0) == 0)
                {
                    s.value -= 0.029f;
                }
                if (PlayerPrefs.GetInt("canon", 0) == 1)
                {
                    s.value -= 0.019f;
                }
                if (PlayerPrefs.GetInt("canon", 0) == 2)
                {
                    s.value -= 0.009f;
                }
            }
        }
    }
    public void gameover()
    {
        Time.timeScale = 0;
        canon.SetActive(false);
        pausebutton.SetActive(false);
        fire.SetActive(false);
        health1.SetActive(false);
        slider.SetActive(false);
        tankspawner.SetActive(false);
        aircraftspawner.SetActive(false);
        gameovertext.SetActive(true);
        mainmenu.SetActive(true);
        livescore1.SetActive(false);
        score.text = livescore.text;
        if (b)
        {
            totalscore += p.score;
            PlayerPrefs.SetInt("totalscore1", totalscore);
            b = false;
            Advertisement.Show(adunitid._adUnitId, this);
            Advertisement.Load(adunitid._adUnitId, this);
        }
        money.text = totalscore + "";

    }
    public void restartgame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       
        audio.SetActive(true);
        image.SetActive(false);
    }
    public void resumegame()
    {
        Time.timeScale = 1;
        resume.SetActive(false);
        mainmenu.SetActive(false);
        pausebutton.SetActive(true);
        fire.SetActive(true);
        slider.SetActive(true);
        livescore1.SetActive(true);


    }
    public void pausegame()
    {
        Time.timeScale = 0;
        resume.SetActive(true);
        mainmenu.SetActive(true);
        pausebutton.SetActive(false);
        fire.SetActive(false);
        slider.SetActive(false);
        livescore1.SetActive(false);


    }
    public void OnUnityAdsAdLoaded(string adUnitId)
    {
        // Optionally execute code if the Ad Unit successfully loads content.
    }

    public void OnUnityAdsFailedToLoad(string _adUnitId, UnityAdsLoadError error, string message)
    {
        Debug.Log($"Error loading Ad Unit: {_adUnitId} - {error.ToString()} - {message}");
        // Optionally execute code if the Ad Unit fails to load, such as attempting to try again.
    }
    public void OnUnityAdsShowFailure(string _adUnitId, UnityAdsShowError error, string message)
    {
        Debug.Log($"Error showing Ad Unit {_adUnitId}: {error.ToString()} - {message}");
        // Optionally execute code if the Ad Unit fails to show, such as loading another ad.
    }
    public void OnUnityAdsShowStart(string _adUnitId) { }
    public void OnUnityAdsShowClick(string _adUnitId) { }
    public void OnUnityAdsShowComplete(string _adUnitId, UnityAdsShowCompletionState showCompletionState) { }
}
