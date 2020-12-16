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

public class RandomRotation : MonoBehaviour {

   
    HingeJoint2D hinge;
    public JointMotor2D mot;
    [SerializeField]
    float[] RotSpeed;
    // Use this for initialization
    void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<Joint2D>().connectedBody = GetComponent<Rigidbody2D>();
        }
        RanAng();        
    }
    void Update()
    {
        
    }
    void Invokes()
    {        
        float ran = Random.Range(2.2f,7.2f);
        Invoke("RanAng", ran);
    }
    void RanAng()
    {
        hinge = GetComponent<HingeJoint2D>();
        mot = hinge.motor;
        mot.motorSpeed = Random.Range(300, -300);
        if (mot.motorSpeed > 100 || mot.motorSpeed < -100)
        {
            GetComponent<HingeJoint2D>().motor = mot;
        } else
        {
            mot.motorSpeed = RotSpeed[Random.Range(0, RotSpeed.Length)];
            GetComponent<HingeJoint2D>().motor = mot;
        }
        Invokes();
    }
}
