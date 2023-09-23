using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncraft : MonoBehaviour
{
    public GameObject tank;
    public float spawnrate = 100;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnrate = 50;
        spawntanks();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawntanks();
            timer = 0;
        }


    }
    void spawntanks()
    {

        Instantiate(tank, transform.position, transform.rotation);

    }
}


