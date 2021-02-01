using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 8f;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Test());

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Respawn()
    {
        transform.position = new Vector3(201, 180, -174);

        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
    }

    IEnumerator Test()
    {

        yield return new WaitForSeconds(2);
        Respawn();
    }
}
