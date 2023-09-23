using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tutorial : MonoBehaviour
{
    public Text t1;
    public Text t2;
    public Text t3;
    public Text t4;
    public GameObject t;
    public GameObject tutorial1;
    public GameObject tank;
    public GameObject craft;

    float timer = 0;
    float timer1 = 0;

    public float f = 1;
    public float f1 = 0;
    public bool l = true;
    public bool l1 = true;
    public bool l2 = false;
    public bool l3 = true;
    public bool l4 = true;
    bool b = true;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("tutorial", 0) == 1)
        {

            tutorial1.SetActive(false);

           
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("tutorial", 0) == 1)
        {

            tutorial1.SetActive(false);
          

        }
        if (timer < 8 && l1)
        {
            timer += Time.deltaTime;

        }
        else
        {
            if (f <= 0.9f && l)
            {
                f += 1.5f * Time.deltaTime;
                t1.color = new Color(0, 0, 0, f);
                t2.color = new Color(0, 0, 0, f);
                t3.color = new Color(0, 0, 0, f);
            }
            else
            {
                f -= 1.0f * Time.deltaTime;
                t1.color = new Color(0, 0, 0, f);
                t2.color = new Color(0, 0, 0, f);
                t3.color = new Color(0, 0, 0, f);
                l = false;
                if (f <= 0)
                {
                    t.SetActive(false);
                    l1 = false;
                    l2 = true;
                    f = 1;
                }
            }
        }
        if (l2)
        {
            if (timer1 < 3 && l4)
            {
                timer1 += Time.deltaTime;
                if (f1 <= 0.9f && l3)
                {
                    f1 += 1.5f * Time.deltaTime;
                    t4.color = new Color(0, 0, 0, f1);

                }

            }
            else
            {
                l4 = false;
              
                
                
                    f1 -= 1.0f * Time.deltaTime;
                    t4.color = new Color(0, 0, 0, f1);
                    l3 = false;

                    if (f1 <= 0)
                    {
                    PlayerPrefs.SetInt("tutorial", 1);
                        tutorial1.SetActive(false);
                        l2 = false;
                      
                    }
                
            }

        }

    }
}
