using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetank : MonoBehaviour
{
    public GameObject fire;
    public GameObject ball;
    public float spawnrate = 1;
    private float timer = 0;
    private float timer1 = 0;

    bool b=false;
    public float r;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        r = Random.Range(2f, 5.5f);
        transform.position = new Vector3(11.72f, -2.98f, -2f);
        speed = Random.Range(0.5f,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
      

        if (b)
        {
            if (timer < spawnrate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = 0;
                Destroy(gameObject);

            }
        }
        if (transform.position.x >= r)
        {
            if (timer1 < spawnrate)
            {

                transform.position += Vector3.left * speed * Time.deltaTime;
                timer1 += Time.deltaTime;
            }
            else
            {
                speed = Random.Range(0.5f, 1.5f);
                timer1 = 0;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {

        if (collision.gameObject.tag.Equals("canon") == true)
        {
            fire.SetActive(true);
            b = true;
        }
    }
  
}
