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
[ExecuteInEditMode]
public class ExecuteInEdit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i =1; i < transform.childCount; i++)
        {
            transform.GetChild(i).position = new Vector3( transform.GetChild(i - 1).position.x-5, 1.8f,0);
            transform.GetChild(i).name = "FruitContainer" + i;
        }
	}
}
