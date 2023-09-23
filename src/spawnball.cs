using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnball : MonoBehaviour
{
    public GameObject ball;
    
    void Start()
    {
        spawnballs();
    }
    // Start is called before the first frame update
  

    // Update is called once per frame
  
    public void spawnballs()
    {        
        Instantiate(ball, transform.position, transform.rotation);
        
    }
}
