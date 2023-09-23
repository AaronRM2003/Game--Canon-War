using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blackout : MonoBehaviour
{
    public GameObject image;
    public Image b;
    public float f = 0;
    public bool l = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (f <= 0.9f && l)
        {
            f += 1.5f * Time.deltaTime;
            b.color = new Color(0, 0, 0, f);
        }
        else
        {
            f -= 1.0f * Time.deltaTime;
            b.color = new Color(0, 0, 0, f);
            l = false;
            if (f <= 0)
            {
                image.SetActive(false);
                f = 0;
            }
        }
    }
}
