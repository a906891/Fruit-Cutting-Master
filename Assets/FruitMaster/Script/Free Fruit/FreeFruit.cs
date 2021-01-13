using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FreeFruit : MonoBehaviour
{
    public Transform[] SpwanPoints;

    public GameObject apple;
    public GameObject kiwi;
    public GameObject lemon;
    public GameObject Orange;
    public GameObject PineApple;
    public GameObject WaterMelon;

    public float minDelay = .001f;
    public float maxDelay = .005f;


    public float TimeRemaining = 8;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    // Update is called once per frame
    void Update()
    {

        print(Convert.ToInt32(TimeRemaining));

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

    IEnumerator SpawnFruits()
    {
        while (true)
        {
            float delay = UnityEngine.Random.Range(minDelay, maxDelay);


            int spawnIndex = UnityEngine.Random.Range(0, SpwanPoints.Length);
            int spawnIndex2 = UnityEngine.Random.Range(0, SpwanPoints.Length);
            int spawnIndex3 = UnityEngine.Random.Range(0, SpwanPoints.Length);

            Transform spawnPoint = SpwanPoints[spawnIndex];
            Transform spawnPoint2 = SpwanPoints[spawnIndex2];
            Transform spawnPoint3 = SpwanPoints[spawnIndex3];



            Instantiate(apple, spawnPoint.position , spawnPoint.rotation);
           


            Instantiate(PineApple, spawnPoint3.position, spawnPoint3.rotation);
            yield return new WaitForSeconds(delay);


            Instantiate(Orange, spawnPoint2.position, spawnPoint2.rotation);
            yield return new WaitForSeconds(delay);


            Instantiate(WaterMelon, spawnPoint3.position, spawnPoint3.rotation);
      


            Instantiate(kiwi, spawnPoint.position , spawnPoint.rotation);
            yield return new WaitForSeconds(delay);


            Instantiate(lemon, spawnPoint2.position , spawnPoint2.rotation);
            yield return new WaitForSeconds(delay);


            Instantiate(PineApple, spawnPoint3.position, spawnPoint3.rotation);
            


            Instantiate(Orange, spawnPoint2.position, spawnPoint2.rotation);

            yield return new WaitForSeconds(delay);
        }
    }
}
