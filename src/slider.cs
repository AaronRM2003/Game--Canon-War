using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class slider : MonoBehaviour
{
    public Transform t;
    public Slider s;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0,0, s.value);
        t.rotation = Quaternion.Euler(0, 0, s.value+30);

    }
}
