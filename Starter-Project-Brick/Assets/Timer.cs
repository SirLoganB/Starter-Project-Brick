using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = -2f;
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
        timer += Time.deltaTime;
        timerText.text = "Timer: " + Mathf.Round(timer);
    }

    IEnumerator End1()
    {

        yield return new WaitForSeconds(12);
        Destroy(gameObject);
    }
}