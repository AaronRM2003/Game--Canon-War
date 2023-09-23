using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeball : MonoBehaviour
{
    public GameObject ball;
    public GameObject audio;
    public AudioSource click;
    // Start is called before the first frame update
    public void activecanonball() 
    {
        ball.SetActive(true); 
        
    }

    public void clkaudio()
    {
        audio.SetActive(true);
        click.Play();
    }
}
