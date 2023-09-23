using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecraft : MonoBehaviour
{
    public GameObject fire;
    public GameObject ball;

    public GameObject g;
    public float spawnrate = 1;
    private float timer = 0;
    bool b = false;
    public float r;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        r = Random.Range(1f, 2.5f);
        transform.position = new Vector3(11.72f, 0.5f, -2f);
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
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("canon")== true)
        {
            fire.SetActive(true);
            b = true;
        }
    }

}
