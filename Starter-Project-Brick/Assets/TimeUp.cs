using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUp : MonoBehaviour
{
    Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = gameObject.GetComponent<Text>();
        StartCoroutine(End1());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator End1()
    {

        yield return new WaitForSeconds(12);
        timerText.text = "Time's Up!";
        Time.timeScale = 0f;
    }
}