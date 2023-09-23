using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class airshoot : MonoBehaviour
{
    public GameObject audio;
    public Rigidbody2D rigidbody1;
    public Transform tankball;
    public Slider s;
    public float f;
    public SpriteRenderer sprite;
    public GameObject aircraft;
    public movecraft m;
    public Collider2D collider1;
    public Collider2D collider2;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreLayerCollision(2, 3);
        Physics2D.IgnoreLayerCollision(2, 2);
        Physics2D.IgnoreLayerCollision(2, 4);
        Physics2D.IgnoreLayerCollision(3, 6);
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collider1);
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collider2);
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GetComponent<Collider2D>());
        m = aircraft.GetComponent<movecraft>();
        sprite = GetComponent<SpriteRenderer>();
        s.value = 1;
        transform.position = new Vector3(8.72f, 0.5f, 0.45f);
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collider2);
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collider1);
        if (transform.position.x <= m.r)
        {
            sprite.maskInteraction = SpriteMaskInteraction.VisibleOutsideMask;
            rigidbody1.velocity = new Vector3(-5.4f, -2, 0);
            audio.SetActive(true);
           // transform.position += Vector3.left * 5f * Time.deltaTime;

            if (transform.position.x <= -7.5)
            {

                //  rigidbody1.velocity = Vector3.zero;
                // rigidbody1.angularVelocity = Vector3.zero;
                /*  if (s.value >= 0.10f)
                  {
                      f -= 0.10f;
                      s.value -= 0.10f;
                  }*/
            }
        }
        // sprite.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;

        if (transform.position.x <= -8.5)
        {
            //  rigidbody1.velocity = Vector3.zero;
            // rigidbody1.angularVelocity = Vector3.zero;

            transform.position = new Vector3(m.r-0.5f, 0.5f, -2f);
            audio.SetActive(false);


        }


    }
}
