using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speeder : MonoBehaviour
{
    public GameObject s;
    public GameObject s1;
    public movetank sp;
    public movecraft sp1;
    float timer=0;
    public bool b1 = false;
    public GameObject sa;
    public spawntank spa;
    public GameObject sa1;
    public spawncraft spa1;
 
    // Start is called before the first frame update
    void Start()
    {
        sp = s.GetComponent<movetank>();
        sp1 = s1.GetComponent<movecraft>();
        spa = sa.GetComponent<spawntank>();
        spa1 = sa1.GetComponent<spawncraft>();
       

    }

    // Update is called once per frame
    void Update()
    {

        if (timer < 10)
        {
            timer += Time.deltaTime;
        }
        else
        {
            sp.speed = sp.speed + 0.1f;
            sp1.speed = sp1.speed + 0.3f;

            spa.spawnrate -= 0.2f;
            spa1.spawnrate -= 0.05f;
            timer = 0;
        }
    }
}
