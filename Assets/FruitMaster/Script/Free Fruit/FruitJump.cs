using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float forceUp = 1f;

    public int spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
            rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.right * forceUp, ForceMode2D.Impulse);
        
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
