using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class value : MonoBehaviour
{
    public Slider s;
    public float f;
    // Start is called before the first frame update
    void Start()
    {
        s.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        f = s.value;
    }
}
