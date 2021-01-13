using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WheelSpinning : MonoBehaviour
{
    
    private int randomValue;
    private float timeInterval;
    private bool coroutineAllowed;
    private int finalAngle;
    private int spincoin;
   
    public GameObject WinText;

    [SerializeField]
    private Text winText;

    // Start is called before the first frame update
    void Start()
    {
        coroutineAllowed = true;
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && coroutineAllowed)
        {
            StartCoroutine(Spin());
            
        }
           
    }

   
    private IEnumerator Spin()
    {
        coroutineAllowed = false;
        randomValue = Random.Range(20, 30);
        timeInterval = 0.01f;

        for (int i = 0; i < randomValue; i++)
        {
            transform.Rotate(0, 0, 22.5f);
            if (i > Mathf.RoundToInt(randomValue * 0.5f))
                timeInterval = 0.05f;
            if (i > Mathf.RoundToInt(randomValue * 0.85f))
                timeInterval = 0.1f;
            yield return new WaitForSeconds(timeInterval);
        }

        if (Mathf.RoundToInt(transform.eulerAngles.z) % 45 != 0)
            transform.Rotate(0, 0, 22.5f);

        finalAngle = Mathf.RoundToInt(transform.eulerAngles.z);

        WinText.SetActive(true);

        switch (finalAngle)
        {
            case 0:
                winText.text = "You Win 80";
                spincoin = 80;
                    break;
            case 45:
                winText.text = "You Win 70";
                spincoin = 70;
                break;
            case 90:
                winText.text = "You Win 60";
                spincoin = 60;
                break;
            case 135:
                winText.text = "You Win 50";
                spincoin = 50;
                break;
            case 180:
                winText.text = "You Win 40";
                spincoin = 40;
                break;
            case 225:
                winText.text = "You Win 30";
                spincoin = 30;
                break;
            case 270:
                winText.text = "You Win 20";
                spincoin = 20;
                break;
            case 315:
                winText.text = "You Win 10";
                spincoin = 10;
                break;
        }
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") +spincoin);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
        coroutineAllowed = true;
    }
}
