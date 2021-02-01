using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioSource backgroundMusic = gameObject.GetComponent<AudioSource>();
        backgroundMusic.PlayDelayed(12);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
