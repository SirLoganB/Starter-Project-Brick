using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int Scores;
    public Text WinText;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Scores >= 3)
        {
            source = GetComponent<AudioSource>();
            source.clip = Resources.Load<AudioClip>("winSound");
            source.Play();
            WinScreen();
        }
    }
    void WinScreen()
    {
        source.Play();
        WinText.text = "You Win!";
        Time.timeScale = 0f;

    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "brick")
        {
            source.Play();
            AddScore();
            Destroy(other.gameObject);
        }
    }
    void AddScore()
    {
        Scores++;
    }
}
