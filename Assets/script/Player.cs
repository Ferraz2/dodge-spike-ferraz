using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    private int seconds;

    [SerializeField]
    private TextMeshProUGUI secondsText;

    [SerializeField]
    private TextMeshProUGUI finalScoreText;

    [SerializeField]
    private GameObject finalscreen;
            
    void Start()
    {
        seconds = 0;
        finalscreen.SetActive(false);
        myRigidbody = GetComponent<Rigidbody2D>();
        InvokeRepeating("UpdateSeconds", 1f, 1f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            Death();
        }
    }

        void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), 0);
        myRigidbody.velocity = input * 10;
    }
    private void Death()
    {
        int maxSeconds = PlayerPrefs.GetInt("Score");
        if (maxSeconds < seconds)
        {
            PlayerPrefs.SetInt("Score", seconds);
        }
        finalscreen.SetActive(true);
        finalScoreText.text = "Final Score:  " + seconds + " Seconds";
        Destroy(gameObject);
    }

    private void UpdateSeconds()
    {
        seconds = seconds + 1;
        secondsText.text = "Seconds: " + seconds;
    }


}
