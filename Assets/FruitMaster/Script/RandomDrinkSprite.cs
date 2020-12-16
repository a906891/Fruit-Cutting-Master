using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Fruit Master. This Project was made in August 2018. If you like the project add me on Facebook and follow me on Instagram to never miss and Update.                                            
/// Credit: Satyam Parkhi
/// Email: satyamparkhi@gmail.com
/// Facebook : https://www.facebook.com/satyamparkhi
/// Instagram : https://www.instagram.com/satyamparkhi/
/// Whatsapp : +91 7050225661
/// </summary>
public class RandomDrinkSprite : MonoBehaviour {
    [SerializeField]
    Sprite[] DrinkGlass;
    public int coinCount = 3;
    public GameObject Coin;
    int coincon;
	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = DrinkGlass[Random.Range(0, DrinkGlass.Length)];
    }

    // Update is called once per frame
    public void Deactive () {
        GetComponent<SpriteRenderer>().sprite = DrinkGlass[Random.Range(0, DrinkGlass.Length)];
        gameObject.SetActive(false);
	}
    public void Coins()
    {
        transform.GetChild(0).GetComponent<AudioSource>().Play();
        InvokeRepeating("CoinInst",0,.1f);
    }
    void CoinInst()
    {
        if (coincon < coinCount)
        {
            coincon++;
            Instantiate(Coin, transform.position, Quaternion.identity);
        }
        else
        {
            coincon = 0;
            CancelInvoke("CoinInst");           
        }
       
    }
}
