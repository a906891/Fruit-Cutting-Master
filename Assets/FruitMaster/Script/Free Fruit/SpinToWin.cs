using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpinToWin : MonoBehaviour
{
    public Button Spin;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = Spin.GetComponent<Button>();
        btn.onClick.AddListener(EnterSpinMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnterSpinMode()
    {
        SceneManager.LoadScene("Spin");
    }

}
