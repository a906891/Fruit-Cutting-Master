using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameManager : MonoBehaviour {
    [HideInInspector]
    public int ScoreCount;
    public Text Score;
    public Text LevelText;    
    public Slider LevelSlider;
    public Transform FruitStorage;
    public GameObject LevComp;
    public GameObject GameOver;
    public GameObject ExitMen;
    float SliderValue;
    [HideInInspector]
    public GameObject activeFruitCont;

    public bool FreeFruitsNeverLoaded = true;

    // Use this for initialization
    void Awake () {
        //when game starts the player should be at the first level
        

        if (PlayerPrefs.GetInt("first") == 0)
        {
            PlayerPrefs.SetInt("LevCount", 1);
            PlayerPrefs.SetInt("first", 1);
        }
        LevelText.text = "LEVEL " + PlayerPrefs.GetInt("LevCount");        
    }
	
	// Update is called once per frame
	void Update () {
        LevelSlider.value = Mathf.Lerp(LevelSlider.value, SliderValue, 10f * Time.smoothDeltaTime);
        if (Input.GetKeyDown(KeyCode.Escape) && FindObjectOfType<KnifeScript>().Playable ==1)
        {
            ExitMen.SetActive(true);
        }
        print(PlayerPrefs.GetInt("LevCount"));
        FreeFruits();
    }
    public void ScoreSet()
    {       
        Score.text = ScoreCount.ToString();
    }
    public void SliderSet()
    {
        if (LevelSlider.value < 1)
        {
            SliderValue = SliderValue + .1f / (PlayerPrefs.GetInt("LevCount"));
        }
        else
        {
            LevComp.SetActive(true);
        }       
    }
    public void SliderLoad()
    {
        SliderValue = 0;
        LevelText.text = "LEVEL " + PlayerPrefs.GetInt("LevCount");
    }
    public void Reload()
    {
        
    }

    public void FreeFruits()
    {
        
        if (PlayerPrefs.GetInt("LevCount") > 0 && PlayerPrefs.GetInt("LevCount")%2 == 0)
        {
            int currentLevel = PlayerPrefs.GetInt("LevCount");
            FreeFruitsNeverLoaded = false;
            PlayerPrefs.SetInt("LevCount", currentLevel+1);
            SceneManager.LoadScene("Free Fruits");
           

        }
    }
}
