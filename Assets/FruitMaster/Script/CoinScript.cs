using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Fruit Master. This Project was made in August 2018. If you like the project add me on Facebook and follow me on Instagram to never miss and Update.                                            
/// Credit: Satyam Parkhi
/// Email: satyamparkhi@gmail.com
/// Facebook : https://www.facebook.com/satyamparkhi
/// Instagram : https://www.instagram.com/satyamparkhi/
/// Whatsapp : +91 7050225661
/// </summary>
public class CoinScript : MonoBehaviour {

    public GameObject CoinSound;
	// Use this for initialization
	void Start () {
        cointest();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void cointest()
    {
        transform.GetChild(0).GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Coin" )
        {
            GameObject ab = Instantiate(CoinSound, transform.position, Quaternion.identity);
            Destroy(ab, 1);
            GetComponent<Animator>().SetTrigger("CoinCollected");
            Destroy(col.gameObject);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            transform.GetChild(0).GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
        }
    }
}
