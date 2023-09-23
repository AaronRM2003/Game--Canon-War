using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canontop : MonoBehaviour
{
    public Image top1;
    public Image top2;
    public Image top3;
    public SpriteRenderer canontop1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("canon", 0) == 0)
        {
            canontop1.sprite = top1.sprite;
        }

        if (PlayerPrefs.GetInt("canon", 0) == 1)
        {
            canontop1.sprite = top2.sprite;
        }
        if (PlayerPrefs.GetInt("canon", 0) == 2)
        {
            canontop1.sprite = top3.sprite;
        }
    }
}
