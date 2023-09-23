using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawntank : MonoBehaviour
{
    public GameObject tank;
    public float spawnrate;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnrate = Random.Range(3, 6); 
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
        spawnrate = Random.Range(3, 10);
        Instantiate(tank, transform.position, transform.rotation);

    }
}


