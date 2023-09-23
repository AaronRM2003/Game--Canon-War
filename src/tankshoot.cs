using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class tankshoot : MonoBehaviour
{
    //   public Rigidbody2D rigidbody1;
    public GameObject audio;
    public Transform tankball;
    public Slider s;
    public float f ;
    public SpriteRenderer sprite;
    public GameObject tank;
    public movetank m;
    public Collider2D collider1;
    public AudioSource click;
    bool b;

    // Start is called before the first frame update
    void Start()
    {
        b = true;
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), collider1);
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), GetComponent<Collider2D>());
        m = tank.GetComponent<movetank>();
        sprite = GetComponent<SpriteRenderer>();
        s.value = 1;
        transform.position = new Vector3(11.72f, -2.64f, -2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= m.r)
        {
            sprite.maskInteraction = SpriteMaskInteraction.VisibleOutsideMask;
            transform.position += Vector3.left * 5f * Time.deltaTime;
            if (b)
            {
                audio.SetActive(true);
                click.Play();
                b = false;
            }
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
          
            transform.position = new Vector3(m.r, -2.64f, -2f);
            b = true;


        }

    
        }
}
