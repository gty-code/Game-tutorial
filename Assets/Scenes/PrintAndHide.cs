using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;

    int i = 3;
    int testNumber;

    // Start is called before the first frame update
    void Start()
    {
        testNumber = Random.Range(200, 251);
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && i == testNumber)
        {
            rend.enabled = false;
        }

        Debug.Log(gameObject.name + ":" + ++i);
    }
}
