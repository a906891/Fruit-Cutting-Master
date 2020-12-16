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
[RequireComponent(typeof(FruitGenerator))]
public class StorePos : MonoBehaviour {
    FruitGenerator fg;
	// Use this for initialization
	void Start () {
        fg = GetComponent<FruitGenerator>();
        fg.Pos = new Vector3[transform.childCount];
        for (int i = 0; i < fg.Pos.Length; i++)
        {
            fg.Pos[i] = transform.GetChild(i).localPosition;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
