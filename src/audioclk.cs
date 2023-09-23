using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class audioclk : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource click;
    public blackout i;
    public GameObject blackout1;
    public bool b;
    void Start()
    {
        if (b)
        {
            i = blackout1.GetComponent<blackout>();
        }
    }
    public void clkaudio()
    {
        if (b)
        {
            i.l = true;
            blackout1.SetActive(true);
            i.f = 0;
        }
        click.Play();
    }
    void Update()
    {

    }
}
