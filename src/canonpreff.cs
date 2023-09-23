using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canonpreff : MonoBehaviour
{
    public GameObject square;
    public GameObject canon1;
    public GameObject canon2;
    public GameObject canon3;
    public health h;
    public int preff;
    public int cost;
    public static int clk3;
    public static int clk4;
    public int val;
    public int money;
    public GameObject sce;
    public Text moneytext;
    // Start is called before the first frame update
    void Start()
    {
       // PlayerPrefs.SetInt("s3", 0);
        clk3 = PlayerPrefs.GetInt("s3", 0);
        clk4 = PlayerPrefs.GetInt("s4", 0);
        money = PlayerPrefs.GetInt("totalscore1", 0);
        h = square.GetComponent<health>();
        if (clk3 == val || clk4 == val)
        {
            sce.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("canon", 0) == 0)
        {
            canon1.SetActive(true);
            canon2.SetActive(false);
            canon3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("canon", 0) == 1)
        {
            canon1.SetActive(false);
            canon2.SetActive(true);
            canon3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("canon", 0) == 2)
        {
            canon1.SetActive(false);
            canon2.SetActive(false);
            canon3.SetActive(true);
        }
    }
    public void selectpreff()
    {
        if (preff == 0)
        {
            PlayerPrefs.SetInt("canon", preff);
        }
        if (preff == 1)
        {
            if (money >= cost && clk3 == 0)
            {
                money -= cost;
                clk3 = val;
                PlayerPrefs.SetInt("canon", preff);

                PlayerPrefs.SetInt("totalscore1", money);
                moneytext.text = money + "$";
            }
            PlayerPrefs.SetInt("s3", clk3);
        }
        if (preff == 2)
        {
            if (money >= cost && clk4 == 0)
            {
                money -= cost;
                clk4 = val;
                PlayerPrefs.SetInt("canon", preff);

                PlayerPrefs.SetInt("totalscore1", money);
                moneytext.text = money + "$";
            }
            PlayerPrefs.SetInt("s4", clk4);
        }
        if (clk3 == val)
        {
            PlayerPrefs.SetInt("canon", preff);
            sce.SetActive(false);
        }
        if (clk4 == val)
        {
            PlayerPrefs.SetInt("canon", preff);
            sce.SetActive(false);
        }
    }
}
