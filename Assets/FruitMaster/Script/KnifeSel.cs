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
public class KnifeSel : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Check();
    }
	
	// Update is called once per frame
	 public void Check () {
        PlayerPrefs.SetInt("KnifeSel0", 1);
        if (PlayerPrefs.GetInt("KnifeSel") == int.Parse(gameObject.name))
        {
            GetComponent<Outline>().enabled = true;
            transform.parent.parent.parent.GetChild(2).GetComponent<Image>().sprite = transform.GetChild(0).GetComponent<Image>().sprite;
        }
        else
        {
            GetComponent<Outline>().enabled = false;
        }
        if (PlayerPrefs.GetInt("KnifeSel" + gameObject.name) == 1)
        {
            transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
        }
        else
        {
            transform.GetChild(0).GetComponent<Image>().color = new Color(0, 0, 0, 1);
        }
    }
}
