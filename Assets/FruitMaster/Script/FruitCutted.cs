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

public class FruitCutted : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("MoveToMixer", .2f);
	}
	
	// Update is called once per frame
	void MoveToMixer() {
        gameObject.layer = 8;
        GetComponent<Rigidbody2D>().drag = 0;
        GetComponent<Collider2D>().isTrigger = false;
        GetComponent<Collider2D>().isTrigger = false;
    }
}
