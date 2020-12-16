using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FreeFruit : MonoBehaviour
{
    public GameObject apple;
    public GameObject kiwi;
    public GameObject lemon;
    public GameObject Orange;
    public GameObject PineApple;
    public GameObject WaterMelon;

    public Rigidbody2D MainParent;
    public Rigidbody2D MainParent2;
    public Rigidbody2D MainParent3;


    private Rigidbody2D AppleRigidbody;
    private Rigidbody2D KiwiRigidbody;
    private Rigidbody2D WaterMelonRigidbody;

    private float ForceNumber;

    public float TimeRemaining = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
       // Instantiate(apple,this.transform.position,this.transform.rotation);

       
        /*   Instantiate(kiwi,this.transform.position,this.transform.rotation);
           Instantiate(lemon,this.transform.position,this.transform.rotation);
           Instantiate(Orange,this.transform.position,this.transform.rotation);
           Instantiate(PineApple,this.transform.position,this.transform.rotation);
           Instantiate(WaterMelon,this.transform.position,this.transform.rotation);*/

        if(TimeRemaining%2 == 0 )
        {
            GameObject AppleInstance = Instantiate(apple, this.transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
            AppleInstance.AddComponent<Rigidbody2D>();
            AppleRigidbody = AppleInstance.GetComponent<Rigidbody2D>();

            GameObject KiwiInstance = Instantiate(kiwi, MainParent2.transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
            KiwiInstance.AddComponent<Rigidbody2D>();
            KiwiRigidbody = KiwiInstance.GetComponent<Rigidbody2D>();


            GameObject WaterMelonInstance = Instantiate(WaterMelon, MainParent3.transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
            WaterMelonInstance.AddComponent<Rigidbody2D>();
            WaterMelonRigidbody = WaterMelonInstance.GetComponent<Rigidbody2D>();

        }
        if (Convert.ToInt32(TimeRemaining) % 2 == 0)
        {
            GameObject AppleInstance = Instantiate(apple, this.transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
            AppleInstance.AddComponent<Rigidbody2D>();
            AppleRigidbody = AppleInstance.GetComponent<Rigidbody2D>();

            GameObject KiwiInstance = Instantiate(kiwi, MainParent2.transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
            KiwiInstance.AddComponent<Rigidbody2D>();
            KiwiRigidbody = KiwiInstance.GetComponent<Rigidbody2D>();


            GameObject WaterMelonInstance = Instantiate(WaterMelon, MainParent3.transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
            WaterMelonInstance.AddComponent<Rigidbody2D>();
            WaterMelonRigidbody = WaterMelonInstance.GetComponent<Rigidbody2D>();

        }

        if (TimeRemaining < 8)
        {
            
            MainParent.AddForce(new Vector2(-20f, 0));
            MainParent2.AddForce(new Vector2(10f, 0));
            MainParent3.AddForce(new Vector2(-20f, 0));
           
        }
        else
        {
            MainParent.AddForce(new Vector2(10f, 0));
            MainParent2.AddForce(new Vector2(-20f, 0));
            MainParent3.AddForce(new Vector2(10f, 0));
            
        }

        print(TimeRemaining);
        if (TimeRemaining > 0)
        {
            
           TimeRemaining -= Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene("SampleScene");
        }
        
    }

 
}
