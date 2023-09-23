using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class power : MonoBehaviour
{
    public Rigidbody2D rigidbody1;
    public GameObject b;
    public Transform canon;
    public int score;
    public Text scoreText;
    public Text highscoretext;
    public GameObject highscoreText;
    public GameObject mainmenu;
    public int highscore;
    public GameObject startbutton;
    public GameObject highscorebutton;
    public GameObject store;
    public GameObject text;
    public GameObject instore;
    float timer = 0;
    bool b1 ;
    bool b2;
    bool b3 ;


    // bool b = true;
    // Start is called before the first frame update
    void Start()
    {
        b1 = false;
        b2 = false;
        b3 = false;
        score = 0;
        highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoretext.text = highscore + "";
        transform.position = new Vector3(-9f, -2.8499999f, 0.0299999993f);
        transform.rotation = Quaternion.Euler(0, 0, canon.rotation.z + 30);

        rigidbody1.gravityScale = 0;

    }
    void Update()
    {
        if (transform.position.y <= -5)
        {
            rigidbody1.velocity = Vector3.zero;
            // rigidbody1.angularVelocity = Vector3.zero;

            transform.position = new Vector3(-9f, -2.8499999f, 0.0299999993f);
            transform.rotation = Quaternion.Euler(0, 0, canon.rotation.z + 30);

            rigidbody1.gravityScale = 0;
            b.SetActive(true);

            // b = false;


        }
        if (b1)
        {
            if (timer < 0.7f)
            {
                timer += Time.deltaTime;
            }
            else
            {
                highscoreText.transform.position = new Vector3(highscoreText.transform.position.x, highscoreText.transform.position.y, 0);
                mainmenu.SetActive(true);
                startbutton.SetActive(false);
                text.SetActive(false);
                highscorebutton.SetActive(false);
                store.SetActive(false);
                b1 = false;
                timer = 0;
            }
        }
        if (b2)
        {
            if (timer < 0.7f)
            {
                timer += Time.deltaTime;
            }
            else
            {
                startbutton.SetActive(false);
                text.SetActive(false);
                highscorebutton.SetActive(false);
                store.SetActive(false);
                instore.SetActive(true);
                mainmenu.SetActive(true);
                b2 = false;
                timer = 0;
            }
        }
        if (b3)
        {
            if (timer < 0.7f)
            {
                timer += Time.deltaTime;
            }
            else
            {
                highscoreText.transform.position = new Vector3(highscoreText.transform.position.x, highscoreText.transform.position.y, -1500);
                startbutton.SetActive(true);
                text.SetActive(true);
                highscorebutton.SetActive(true);
                store.SetActive(true);
                instore.SetActive(false);
                mainmenu.SetActive(false);
                b3 = false;
                timer = 0;
            }
        }

    }

    // Update is called once per frame
    public void shoot()
    {
        if (PlayerPrefs.GetInt("canon", 0) == 0)
        {
            rigidbody1.AddForce(transform.right * 600);
            rigidbody1.gravityScale = 1;
            b.SetActive(false);
        }
        if (PlayerPrefs.GetInt("canon", 0) == 1)
        {
            rigidbody1.AddForce(transform.right * 800);
            rigidbody1.gravityScale = 1.5f;
            b.SetActive(false);
        }
        if (PlayerPrefs.GetInt("canon", 0) == 2)
        {
            rigidbody1.AddForce(transform.right * 900);
            rigidbody1.gravityScale = 1.7f;
            b.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("tank") == true || collision.gameObject.tag.Equals("aircraft") == true)
        {
            rigidbody1.velocity = Vector3.zero;
            // rigidbody1.angularVelocity = Vector3.zero;

            transform.position = new Vector3(-9f, -2.8499999f, 0.0299999993f);
            transform.rotation = Quaternion.Euler(0, 0, canon.rotation.z + 30);

            rigidbody1.gravityScale = 0;
            b.SetActive(true);
            score += 10;
            
            if (score > highscore)
            {
                highscore = score;
                PlayerPrefs.SetInt("highscore", score);
                highscoretext.text = highscore + "";

            }

            scoreText.text = score.ToString();
        }
    }
    public void onhighscore()
    {
       /* highscoreText.transform.position = new Vector3(highscoreText.transform.position.x, highscoreText.transform.position.y, 0);
        mainmenu.SetActive(true);
        startbutton.SetActive(false);
        text.SetActive(false);
        highscorebutton.SetActive(false);
        store.SetActive(false);*/
        b1 = true;

    }
    public void openstore()
    {
        b2 = true;


    }
    public void back()
    {
        b3 = true;
    }

}
