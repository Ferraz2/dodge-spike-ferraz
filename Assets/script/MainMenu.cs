using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI secondsText;

    // Start is called before the first frame update
    void Start()
    {
        int seconds = PlayerPrefs.GetInt("Score");
        secondsText.text = "Max Score: " + seconds + " seconds";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
